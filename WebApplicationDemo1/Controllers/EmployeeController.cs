using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo1.Models;

namespace WebApplicationDemo1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {

            ViewData["message"] = "Hello from controller";
            List<string> names = new List<string>() { "IShwari", "Kunali", "Pritee", "Kshitija" };
            ViewData["names"] = names;
            ViewBag.Names = names;

            List<Employee> employees = new List<Employee>(){
            new Employee{ Id=1, Name= "Ishwari", Dept="Development", Salary=30000 },
            new Employee{ Id=2, Name= "Ishwari", Dept="Development", Salary=30000 },
            new Employee{ Id=3, Name= "Ishwary", Dept="Development", Salary=30000 },
            new Employee{ Id=4, Name= "Ishwary", Dept="Development", Salary=30000 },
            new Employee{ Id=5, Name= "Ishwary", Dept="Development", Salary=30000 },
             };
            ViewData["emplist"] = employees;
            ViewBag.Employees = employees;



            return View();
        }
    }
}
