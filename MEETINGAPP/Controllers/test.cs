using Microsoft.AspNetCore.Mvc;

namespace MEETINGAPP.Controllers
{
    public class test : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
