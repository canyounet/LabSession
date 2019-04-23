using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using D18_Session_23Apr2019.Models;
using Microsoft.AspNetCore.Http;

namespace D18_Session_23Apr2019.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult DemoSession()
        {
            //gán gái trị cho Session
            HttpContext.Session.SetString("Ten", "Nhất Nghệ");
            HttpContext.Session.SetInt32("Tuoi", 16);

            HangHoa hh = new HangHoa { HangHoaId = 1, TenHangHoa = "Bia 333", DonGia = 13800 };
            HttpContext.Session.Set<HangHoa>("HangHoa", hh);

            return View();
        }

        public IActionResult Demo()
        {
            DateTime finishCourse = new DateTime(2019, 6, 10);
            string result1 = $"Còn {finishCourse.TinhKhoangCanhNgay(DateTime.Now)} ngày nữa thì kết thúc khóa";

            int N = new Random().Next(1, 20);
            return Json(new
            {
                S1 = result1,
                S2 = $"Tổng {N} số nguyên đầu tiên là {N.TongN()}"
            });
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
