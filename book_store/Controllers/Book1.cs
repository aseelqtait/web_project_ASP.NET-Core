using book_store.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace book_store.Controllers
{
    public class Book1 : Controller
    {
        private Context context { get; set; }
        public Book1(Context ctx)
        {
            context = ctx;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BookDetail(int id)
        {
            if (HttpContext.Session.GetInt32("customerid") == null)
            {
                return RedirectToAction("login", "Customer");
            }
            var p = context.Books.Find(id);
            return View(p);
        }

        [HttpGet]
        public IActionResult deleteBook(int id)
        {
            if (HttpContext.Session.GetInt32("customerid") == null)
            {
                return RedirectToAction("login", "Customer");
            }
            var m = context.Books.Find(id);
            return View(m);
        }

        [HttpPost]
        public IActionResult Delete(Book m)
        {
            if (HttpContext.Session.GetInt32("customerid") == null)
            {
                return RedirectToAction("login", "Customer");
            }
            context.Books.Remove(m);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult newBook()
        {
            if (HttpContext.Session.GetInt32("customerid") == null)
            {
                return RedirectToAction("login", "Customer");
            }
            ViewBag.Action = "Add";
            return View(new Book());
        }
        [HttpPost]
        public IActionResult newBook(Book p)
        {
            if (HttpContext.Session.GetInt32("customerid") == null)
            {
                return RedirectToAction("login", "Customer");
            }
            if (ModelState.IsValid)
            {
                context.Books.Add(p);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {

                return View(p);
            }

        }
        [HttpGet]
        public IActionResult editBook(int id)
        {
           if (HttpContext.Session.GetInt32("customerid") == null)
            {
                return RedirectToAction("login", "Customer");
            }
           

            var m = context.Books.Find(id);
            return View(m);
        }

        [HttpPost]
        public IActionResult editBook(Book p)
        {
            if (HttpContext.Session.GetInt32("customerid") == null)
            {
                return RedirectToAction("login", "Customer");
            }
            if (ModelState.IsValid)
            {
               
                   
                        context.Books.Update(p);
                         context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
               
                return View(p);
            }
        }

    }
}
