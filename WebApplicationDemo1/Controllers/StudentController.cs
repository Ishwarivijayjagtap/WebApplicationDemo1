using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationDemo1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentDeatails()
        {
            List<string> branch = new List<string>() { "Cs", "IT", "Mechanical" };
            ViewData["branch"] = new SelectList(branch);
            return View();
        }
        [HttpPost]
        public IActionResult StudentDeatails(IFormCollection form)
        {
            ViewBag.Name = form["Studentname"];
            ViewBag.Rollno = form["email"];
            ViewBag.Branch = form["cities"];
            ViewBag.CurrentYear = form["currentyear"];

            return View("Display");
        }
    }
}
