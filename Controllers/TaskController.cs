using Microsoft.AspNetCore.Mvc;
using Task_Manager.Data;

namespace Task_Manager.Controllers
{
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TaskController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var tasks = _context.Tasks.ToList();
            return View(tasks);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task != null)
            {
                return View(task);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Create(Task task)
        {
            if (ModelState.IsValid)
            {
                _context.Tasks.Add(task);
                _context.SaveChanges();
            }
            var tasks = _context.Tasks.ToList();
            return PartialView("_Tasks", tasks);
        }

        [HttpPost]
        public IActionResult Update(Task task)
        {
            if (ModelState.IsValid)
            {
                _context.Tasks.Update(task);
                _context.SaveChanges();
            }
            var tasks = _context.Tasks.ToList();
            return PartialView("_Tasks", tasks);
        }

        [HttpPost]
        public IActionResult Delete(Task task)
        {
            if (ModelState.IsValid)
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();
            }
            var tasks = _context.Tasks.ToList();
            return PartialView("_Tasks", tasks);
        }
    }
}
