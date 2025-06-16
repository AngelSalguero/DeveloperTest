using Microsoft.AspNetCore.Mvc;
using ProgrammingLogic.Util;

namespace FrontEnd.Controllers
{
    public class AdminController : Controller
    {
        private userService _userService;
        public AdminController(ILogger<AdminController> logger)
        {
            _userService = new userService();
        }
        public IActionResult Index()
        {
            List<User> users = _userService.getUsers();
            return View(users);
        }
    }
}
