using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cook_Bookstore;
using Cook_Bookstore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cook_BookstoreWebApp.Controllers
{
    public class BookController : Controller
    {
        // GET: BookController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            Book b = BookstoreFunctions.GetBookById(id);
            return View(b);
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            //Populate Author and Genre in viewbag
            ViewBag.Authors = new SelectList(BookstoreFunctions.GetAllAuthorsAsDictionary(), "Key", "Value");
            ViewBag.Genres = new SelectList(BookstoreFunctions.GetAllGenresAsDictionary(), "Key", "Value");
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book b)
        {
            try
            {
                BookstoreFunctions.CreateBook(b);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            Book b = BookstoreFunctions.GetBookById(id);
            ViewBag.Authors = new SelectList(BookstoreFunctions.GetAllAuthorsAsDictionary(), "Key", "Value");
            ViewBag.Genres = new SelectList(BookstoreFunctions.GetAllGenresAsDictionary(), "Key", "Value");
            return View(b);
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book b)
        {
            try
            {
                BookstoreFunctions.UpdateBook(b);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            Book b = BookstoreFunctions.GetBookById(id);
            return View(b);
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Book b)
        {
            try
            {
                BookstoreFunctions.DeleteBook(b);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
