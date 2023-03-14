using Microsoft.AspNetCore.Mvc;
using Cook_Bookstore;
using Cook_Bookstore.Models;
using System.Collections.Generic;

namespace Cook_BookstoreWebApp.Controllers
{
    public class AuthorController : Controller
    {
        // GET: AuthorController
        public ActionResult Index()
        {
            List<Author> authors = BookstoreFunctions.GetAllAuthors();
            return View(authors);
        }

        // GET: AuthorController/Details/5
        public ActionResult Details(int id)
        {
            Author a = BookstoreFunctions.GetAuthorById(id);
            return View(a);
        }

        // GET: AuthorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Author a)
        {
            try
            {
                BookstoreFunctions.CreateAuthor(a);
                return RedirectToAction("Index", "Author");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id)
        {
            Author a = BookstoreFunctions.GetAuthorById(id);
            return View(a);
        }

        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Author a)
        {
            try
            {
                BookstoreFunctions.UpdateAuthor(a);
                return RedirectToAction("Index", "Author");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Delete/5
        public ActionResult Delete(int id)
        {
            Author a = BookstoreFunctions.GetAuthorById(id);
            return View(a);
        }

        // POST: AuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Author a)
        {
            try
            {
                BookstoreFunctions.DeleteAuthor(a);
                return RedirectToAction("Index", "Author");
            }
            catch
            {
                return View();
            }
        }
    }
}
