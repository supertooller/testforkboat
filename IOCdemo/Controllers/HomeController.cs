using IOCdemo.BLL;
using IOCdemo.Models;
using IOCdemo.Service;
using IOCdemo.System;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace IOCdemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetUser()//运行后直接打开https://localhost:7266/home/Getuser
        {
            IUserService userService = new UserService();//可以切换为NewUserService试试
            UserBLL userBLL = new UserBLL(userService);//注入
            User user = userBLL.GetUser(11);

            if(user != null)
            {
                ViewBag.Id = user.Id;
                ViewBag.Name = user.Name;
                ViewBag.Pwd = user.Pwd;
            }
            return View();
        }
    }
}