using Microsoft.AspNetCore.Mvc;

namespace SoftwareSuite.Controllers
{
    public class StudentFeedbackController : Controller
    {
        public IActionResult StudentFeedback()
        {
            return View();
        }
    }
}
