using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BISM.Models.MainSystem;
using BISM.helpers;
using Microsoft.AspNetCore.Http;

namespace BISM.Controllers
{
    public class AccountController : Controller
    {
        private readonly MainSystemContext _mainSystemContext;

        public AccountController(MainSystemContext mainSystemContext)
        {
            _mainSystemContext = mainSystemContext;
        }

        [BindProperty]
        public string ReturnUrl { get; set; }

        public IActionResult Index(string returnUrl= null)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        public async Task<IActionResult>SignIn(Systemusers systemUser, string returnUrl = null)
        {
            if(systemUser.UserCode != null && systemUser.UserCode != "")
            {
                var result = _mainSystemContext.Systemusers.Where(s => s.UserCode == systemUser.UserCode).FirstOrDefault();

                if(result != null)
                {
                    string userPass = dbSecurity.MD5(systemUser.UserPassword);
                    if(result.UserPassword == userPass)
                    {
                        HttpContext.Session.SetString("UserCode", result.UserCode);

                    }
                }
            }
        }
    }
}