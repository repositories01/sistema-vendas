using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Uteis;
using System.Data;




namespace SistemaVendas.Models
{
    public class VendaModel
    {
        public string Id { get; set; }
        public string Cliente_Id { get; set; }
        public string Vendedor_Id { get; set; }

        public double Total { get; set; }

        public string ListaProdutos { get; set; }

        public List<ClienteModel> RetornarListaClientes()
        {
            return new ClienteModel().ListarTodosClientes();
        }

        public List<VendedorModel> RetornarListaVendedores()
        {
            return new VendedorModel().ListarTodosVendedores();
        }


        public List<ProdutoModel> RetornarListaProutos()
        {
            return new ProdutoModel().ListarTodosProdutos();
        }

        public void Inserir()
        {
            DAL objDAL = new DAL();

            string dataVenda = DateTime.Now.Date.ToString("yyyy/mm/dd");

            string sql = "INSERT INTO VENDA(data, total, vendedor_id, cliente_id" +
            $"VALUES('{dataVenda}', '{Total.ToString().Replace(",", ".")}', '{Vendedor_Id}', '{Cliente_Id}')";

            objDAL.ExecutarComandoSQL(sql);


            sql = $"select id from venda where data='{dataVenda}', and vendedor_id='{Vendedor_Id}' and cliente_id='{Cliente_Id}' order by id desc limit 1";



            //recuperar id de venda 
            DataTable dt = objDAL.RetDataTable(sql);
            string id_venda = dt.Rows[0]["id"].ToString();

            //deserializar json

            List<ItemVendaModel> lista_produtos = JsonConvert.DeserializeObject<List<ItemVendaModel>>(ListaProdutos);

            for (int i = 0; i < lista_produtos.Count; i++)
            {
                sql = "insert into itens_venda(venda_id, produto_id, qtde_produto, preco_produto)" +
                $"values'{id_venda}', '{lista_produtos[i].CodigoProduto.ToString()}," +
                $"{lista_produtos[i].QtdeProduto.ToString()}'" +
                 $"{lista_produtos[i].PrecoUnitario.ToString().Replace("," , ".")})'";

                objDAL.ExecutarComandoSQL(sql);

            }


        }



    }






}
