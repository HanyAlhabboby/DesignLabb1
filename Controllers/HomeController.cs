using DesignLabb1.Models;
using DesignLabb1.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DesignLabb1.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly IUserSession _userSession;

        public HomeController(IUserSession userSession) 
        {
        _userSession = userSession;
        }

        public IActionResult Index()
        {
            if(string.IsNullOrEmpty(_userSession.GetSessionId()))
            {
                _userSession.SetSessionId(Guid.NewGuid().ToString());
            }
            var sessionId = _userSession.GetSessionId();
            ViewData["SessionId"]=sessionId;
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
    }
}
