using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using TesteMVC.Models;

namespace TesteMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        
        public ActionResult Index()
        {
            ViewData["teste"] = "ola";
            return View();
        }

        public ActionResult Teste()
        {
            
            var lista = new List<TesteModel>();
            for(int i = 1; i <= 100; i++)
            {
                lista.Add(new TesteModel { Id = i, Nome = "Teste " + i.ToString() });
            }
            //ViewData["lista"] = lista;
            //return View();
            return View(lista);
        }

        public ActionResult TesteRazor()
        {
            //ViewBag.hello = "leo";
            var lista = new List<TesteModel>();
            for (int i = 1; i <= 100; i++)
            {
                lista.Add(new TesteModel { Id = i, Nome = "Teste " + i.ToString() });
            }
            //ViewData["lista"] = lista;
            return View(lista);
            
            //return View();        
        }

        public ActionResult TesteMasterPage()
        {
            return View();
        }
    }
}