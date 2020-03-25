// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using sistema_venda.Models;
// using sistema_venda.uteis.DAL;
// using  Microsoft.AspNetCore.Http;

// namespace sistema_venda.Controllers
// {
//     public class HomeController : Controller
//     {
//         private readonly ILogger<HomeController> _logger;

//         public HomeController(ILogger<HomeController> logger)
//         {
//             _logger = logger;
//         }


//         public IActionResult Menu()
//         {
//             return View();
//         }
//         public IActionResult Index()
//         {
//             return View();
//         }

//         [HttpGet]
//         public IActionResult Login(int? id)
//         {
//               if(id!= null){
               
//               if(id ==0){
//                   HttpContext.Session.SetString("IdUsuarioLogado", string.Empty);
//                     HttpContext.Session.SetString("NomeUsuarioLogado", string.Empty);
//               }


//               }

//             return View();
//         }

//         [HttpPost]
//         public IActionResult Login(LoginModel login)
//         {
//             if (ModelState.IsValid)
//             {

//                 bool loginOk = login.ValidarLogin();
//                 if (loginOk)
//                 {
//                     HttpContext.Session.SetString("idUsuarioLogado", login.Id);  
//                     HttpContext.Session.SetString("NomeUsuarioLogado", login.Nome);
//                      return RedirectToAction("Menu", "Home");

//                 }
//                 else
//                 {
//                     TempData["ErrorLogin"] = "Email ou  senha invalidos!";
//                 }
//             }


//             return View();
//         }

//         public IActionResult Privacy()
//         {
//             return View();
//         }

//         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//         public IActionResult Error()
//         {
//             return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//         }
//     }
// }

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;
using SistemaVendas.Uteis;
using Microsoft.AspNetCore.Http;

namespace SistemaVendas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }

        [HttpGet]        
        public IActionResult Login(int? id)
        {
            //Para realizar o logout
            if (id!=null)
            {
                if (id==0)
                {
                    HttpContext.Session.SetString("IdUsuarioLogado", string.Empty);
                    HttpContext.Session.SetString("NomeUsuarioLogado", string.Empty);
                }
            }
            //Fim

            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            if (ModelState.IsValid)
            {
                bool loginOk = login.ValidarLogin();
                if (loginOk)
                {
                    HttpContext.Session.SetString("IdUsuarioLogado", login.Id);
                    HttpContext.Session.SetString("NomeUsuarioLogado", login.Nome);
                    return RedirectToAction("Menu","Home");
                }
                else
                {
                    TempData["ErrorLogin"] = "E-mail ou Senha são inválidos!";
                }
            }

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
