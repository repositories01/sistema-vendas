using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using SistemaVendas.Models;
using SistemaVendas.Uteis;

namespace sistema_venda.Models
{
    public class ClienteModel
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }



        public List<ClienteModel> ListarTodosClientes()
        {
            List<ClienteModel> lista = new List<ClienteModel>();
            ClienteModel item;
            DAL objDAL = new DAL();
            string sql = "SELECT id, nome, cpf email, senha FROM Cliente order by  nome asc";
            DataTable dt = objDAL.RetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ClienteModel
                {
                    Id = dt.Rows[i]["Id"].ToString(),
                    Nome = dt.Rows[i]["Nome"].ToString(),
                    CPF = dt.Rows[i]["CPF"].ToString(),
                    Email = dt.Rows[i]["Email"].ToString(),
                    Senha = dt.Rows[i]["Senha"].ToString()
                      };
                   lista.Add(item);
            }

            return lista;
        }
    }
}