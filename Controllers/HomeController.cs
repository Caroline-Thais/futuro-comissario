using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_integrador_MVC.Models;

namespace Projeto_integrador_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apostila()
        {
            return View();
        }

         public IActionResult Vagas()
        {
            return View();
        }
        
           
            public IActionResult Concluido()  
            {            
                return View(); 
            } 
        
         public IActionResult Carrinho()  
            {            
                return View(); 
            }
    }          
}
