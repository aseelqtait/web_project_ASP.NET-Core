using book_store.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Controllers
{
    public class HomeController : Controller
    {
        private Context context { get; set; }
        public HomeController(Context ctx)
        {
            context = ctx;

        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("customerid") == null)
           {
                return RedirectToAction("login", "Customer");
           }
            var p = context.Books.ToList();
            return View(p);
        }


        public IActionResult Privacy()
        {
            return View();
        }





        public IActionResult search(string k)
        {
           if (HttpContext.Session.GetInt32("customerid") == null)
            {
                return RedirectToAction("login", "Customer");
            }
            var c = context.Books.Where(e => e.BookName.Contains(k)).OrderBy(e => e.BookName).ToList();
            return View("index", c);
        }
        public IActionResult about()
        {
            if (HttpContext.Session.GetInt32("customerid") == null)
            {
                return RedirectToAction("login", "Customer");
          }
            return View();
        }

    }
}
