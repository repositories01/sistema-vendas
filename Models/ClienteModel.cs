using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;
using SistemaVendas.Uteis;
using Microsoft.AspNetCore.Http;
using System.Data;

namespace sistema_venda.Models
{
    public class ClienteModel
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
         public string Senha{ get; set;}

    

    public List<ClienteModel> ListarTodosClientes(){
        List<ClienteModel> lista = new List<ClienteModel>();
        ClienteModel item;
        DAL objDAL = new DAL();
        string sql = "SELECT id, nome, cpf email, senha FROM Cliente order by  nome asc";
        DataTable dt = objDAL.RetDataTable(sql);
        for (int i =0; i<dt.Rows.Count; i++){
            
        }
    }
    }
}