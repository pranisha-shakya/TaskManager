using Microsoft.AspNetCore.Mvc;

namespace Task_Manager.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
