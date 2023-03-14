using Microsoft.AspNetCore.Mvc;
using Cook_Bookstore;
using Cook_Bookstore.Models;
using System.Collections.Generic;

namespace Cook_BookstoreWebApp.Controllers
{
    public class GenreController : Controller
    {
        // GET: GenreController
        public ActionResult Index()
        {
            List<Genre> genres = BookstoreFunctions.GetAllGenres();
            return View(genres);
        }

        // GET: GenreController/Details/5
        public ActionResult Details(int id)
        {
            Genre g = BookstoreFunctions.GetGenreById(id);
            return View(g);
        }

        // GET: GenreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Genre g)
        {
            try
            {
                BookstoreFunctions.CreateGenre(g);
                return RedirectToAction("Index", "Genre");
            }
            catch
            {
                return View();
            }
        }

        // GET: GenreController/Edit/5
        public ActionResult Edit(int id)
        {
            Genre g = BookstoreFunctions.GetGenreById(id);
            return View(g);
        }

        // POST: GenreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Genre g)
        {
            try
            {
                BookstoreFunctions.UpdateGenre(g);
                return RedirectToAction("Index", "Genre");
            }
            catch
            {
                return View();
            }
        }

        // GET: GenreController/Delete/5
        public ActionResult Delete(int id)
        {
            Genre g = BookstoreFunctions.GetGenreById(id);
            return View(g);
        }

        // POST: GenreController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Genre g)
        {
            try
            {
                BookstoreFunctions.DeleteGenre(g);
                return RedirectToAction("Index", "Genre");
            }
            catch
            {
                return View();
            }
        }
    }
}
