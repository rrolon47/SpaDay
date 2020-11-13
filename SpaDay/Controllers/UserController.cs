using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        //Get: "/user/index"
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpGet]
        [Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                ViewBag.Username = newUser.Username;
                return View("Index");
            }
            else
            {
                ViewBag.Error = "Passwords do not match. Try again.";
                //ViewBag.Username = newUser.Username;
                //ViewBag.Email = newUser.Email;

                return View("Add");
            }
        }
    }
}
