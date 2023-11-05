using Microsoft.AspNetCore.Mvc;
using Mercadinho.Models;
using System.Diagnostics;

namespace Mercadinho.Controllers
{
    public class HomeController : Controller
    {
        //classe que herda de Controller,tudo que precisamos esta dentro dessa classe Controller

        public IActionResult Index()
        {   
            Item mercadinho = new Item();
            return View(mercadinho);
        }
        //Index é a nossa página principal

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}