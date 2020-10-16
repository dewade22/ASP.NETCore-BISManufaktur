using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BISM.Models.MainSystem;
using Microsoft.AspNetCore.Http;
using BISM.helpers;

namespace BISM.Controllers
{
    public class HomeController : Controller
    {
        MainSystemContext _mainSystemContext = new MainSystemContext();

        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("UserCode")== null)
            {
                return Redirect("/Account/Login");
            }
            return View();
        }

        [AuthorizedAction]
        public IActionResult Privacy()
        {
            return View();
        }
        [AuthorizedAction]
        public IActionResult show()
        {
            return View("Index");
        }
    }
}
