using Microsoft.AspNetCore.Mvc;

namespace CrudTheme.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
