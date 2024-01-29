using MEETINGAPP.Models;
using Microsoft.AspNetCore.Mvc;
//using System.Diagnostics;

namespace MEETINGAPP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() 
        {

             int saat = DateTime.Now.Hour;

            ViewData["Salamlama"] = saat > 12 ? "Iyi gunler" : "Gunaydin";
          int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
           

            var meetingInfo = new MeetingInfO()
            {
                Id = 1,
                Location = "Baku, Haydar Aliyev Kongre Merkezi",
                Date = DateTime.Parse("2024-01-20 14:00"),
                NumberofPeople = UserCount
            };

            return View(meetingInfo);
        }



    }
}
