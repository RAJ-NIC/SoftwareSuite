using Microsoft.AspNetCore.Mvc;

namespace SoftwareSuite.Controllers
{
    public class ViewSyllabusController : Controller
    {
        public IActionResult Syllabus()
        {
            return View();
        }
    }
}
