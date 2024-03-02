using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission08_3_12.Models;
using System.Diagnostics;
using System.Threading.Tasks;
using SQLitePCL;

namespace Mission08_3_12.Controllers
{
    public class HomeController : Controller
    {
        private ITaskRepository _repo;
        public HomeController(ITaskRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            var category = _repo.Tasks.Include("Category")
                .OrderBy(x => x.Category.CategoryName);

            return View(category);
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            ViewBag.Categories = _repo.Categories
                .OrderBy(x => x.CategoryName);

            return View(new TaskFix());
        }

        [HttpPost]
        public IActionResult AddTask(TaskFix response)
        {
            _repo.AddSingleTask(response);

            return View(response);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _repo.Tasks
                .Single(x => x.TaskId == id);

            ViewBag.Categories = _repo.Categories 
                .OrderBy(x => x.CategoryName);

            return View("AddTask", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(TaskFix app)
        {
            _repo.AddSingleTask(app);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _repo.Tasks
                .Single(x => x.TaskId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(TaskFix app)
        {
            _repo.RemoveSingleTask(app);

            return RedirectToAction("Index");
        }
    }
}
