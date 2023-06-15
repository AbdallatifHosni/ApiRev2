using Microsoft.AspNetCore.Mvc;
using Day1.Services;
namespace Day1.Controllers
{
    public class ServiceController : Controller
    {
        IStudentRepository studentRepository;
        public ServiceController(IStudentRepository _studentRepository)//inject
        {
            studentRepository = _studentRepository;
        }
        public IActionResult Index()
        {
            ViewData["serviceID"] = studentRepository.id;
            return View();
        }
    }
}
