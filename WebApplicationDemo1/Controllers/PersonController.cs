using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace WebApplicationDemo1.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult PersonalDeatails()
        { 
            List<string> cities = new List<string>() { "Pune", "Mumbai", "Delhi", "Surat" };
            ViewData["cities"] = new SelectList(cities);
            return View();
        }
        [HttpPost]
        public IActionResult PersonalDeatails(IFormCollection form)
        {
            ViewBag.Name = form["personame"];
            ViewBag.Email = form["email"];
            ViewBag.City = form["cities"];

            return View("Display");
        }


    }
}
