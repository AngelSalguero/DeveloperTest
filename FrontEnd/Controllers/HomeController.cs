using FrontEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ProgrammingLogic.Util;
using Umbraco.Core.Services.Implement;

namespace FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private userService _userService;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _userService = new userService();
        }

        public IActionResult Index()
        {
            List<User> users = _userService.getUsers();

            /*
             with a given list of users return them to the view in the way you want.
             with that list of users create an list of all the info you get
             */

            return View(users);
        }

        public IActionResult Pokemon()
        {
            return View();
        }

    }
}
