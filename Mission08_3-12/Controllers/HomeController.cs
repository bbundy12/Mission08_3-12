using Microsoft.AspNetCore.Mvc;
using Mission08_3_12.Models;
using System.Diagnostics;

namespace Mission08_3_12.Controllers
{
    public class HomeController : Controller
    {
        private iTaskRepository _repo;
        public HomeController(iTaskRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddTask()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        //public IActionResult MovieList()
        //{
        //    var movies = _context.Movies.ToList();

        //    return View(movies);
        //}

        //[HttpGet]
        //public IActionResult Contribute()
        //{
        //    ViewBag.Categories = _context.Categories.ToList();
        //    return View("Contribute");
        //}

        //[HttpPost]
        //public IActionResult Contribute(Movie response)
        //{
        //    _context.Movies.Add(response);
        //    _context.SaveChanges();

        //    return View("Success", response);
        //}

        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    var recordToEdit = _context.Movies
        //        .Single(x => x.MovieId == id);

        //    ViewBag.Categories = _context.Categories.ToList();

        //    return View("Contribute", recordToEdit);
        //}

        //[HttpPost]
        //public IActionResult Edit(Movie app)
        //{
        //    _context.Update(app);
        //    _context.SaveChanges();

        //    return RedirectToAction("MovieList");
        //}

        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    var recordToDelete = _context.Movies
        //        .Single(x => x.MovieId == id);

        //    return View(recordToDelete);
        //}

        //[HttpPost]
        //public IActionResult Delete(Movie app)
        //{
        //    _context.Movies.Remove(app);
        //    _context.SaveChanges();

        //    return RedirectToAction("MovieList");
        //}
    }
}
