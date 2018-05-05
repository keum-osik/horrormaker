using AspnetCoreStudy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace AspnetCoreStudy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var hongUser = new User
            {
                UserNo = 1,
                UserName = "홍길동"
            };

            //return View(hongUser);

            ViewBag.User = hongUser;

            ViewData["User"] = hongUser;

            return View();
        }


        public IActionResult LoginSuccess()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
