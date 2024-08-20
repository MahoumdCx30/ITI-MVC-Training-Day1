using ITI_MVC_Assingment_D1.Data;
using Microsoft.AspNetCore.Mvc;

namespace ITI_MVC_Assingment_D1.Controllers
{
    public class StudentController : Controller
    {
       
        public IActionResult Index()
        {
            var _context = new ApplicationDbContext();
            var students = _context.Students.ToList();
            return View("StudentsDetails" , students);
        }

        public IActionResult Details(int id)
        {
            var _context = new ApplicationDbContext();
            var student = _context.Students.Find(id);
            return View("StudentData", student);
        }
    }
}
