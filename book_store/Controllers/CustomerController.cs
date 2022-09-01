using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using book_store.Models;
using System.Linq;

namespace book_store.Controllers
{
    public class CustomerController : Controller
    {
       private Context context { get; set; }
        public CustomerController(Context ctx)
        {
            context = ctx;

        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult login()
        {
            return View("login");
        }
        [HttpPost]
        public IActionResult login(Login l)
        {
            if (ModelState.IsValid)
            {
                Login logindata = context.Login.Where(e => e.Email.Equals(l.Email)).ToList().First();
                
                 if (logindata.Password.Equals(l.Password))
                {
                   
                    HttpContext.Session.SetInt32("customerid", l.CustomerId);
                    
                    return RedirectToAction("Index","Home");

                }
            }
            
            return View("login");
        }
        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return View("login");
        }









    }
}
