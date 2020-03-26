using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;
namespace sistema_venda.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.ListaClientes = new ClienteModel().ListarTodosClientes();
            return View();
        }
    }
}