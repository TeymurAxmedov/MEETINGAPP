using MEETINGAPP.Models;
using Microsoft.AspNetCore.Mvc;


namespace MEETINGAPP.Controllers
{
    public class MeetingController : Controller
    {

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo Model)
        {
            //database
            //list
            //if (ModelState.IsValid)
            //{
              
            //}
            //else
            //{
            //    return View(Model);
            //}
            Repository.CreateUser(Model);
            ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
            return View("Thanks", Model);

        }



        [HttpGet]
        public IActionResult List()
        {

            return View(Repository.Users);
        }

        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }


    }
}
