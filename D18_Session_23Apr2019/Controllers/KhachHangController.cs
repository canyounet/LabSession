using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace D18_Session_23Apr2019.Controllers
{
    public class KhachHangController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            if(ModelState.IsValid)
            {
                //ghi session
                HttpContext.Session.SetString("LoginName", Username);
                //chuyển tới
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public IActionResult Logout()
        {
            //xóa session
            HttpContext.Session.Remove("LoginName");
            //chuyển tới
            return RedirectToAction("Index", "Home");            
        }
        public IActionResult Profile()
        {
            return View();
        }
    }
}