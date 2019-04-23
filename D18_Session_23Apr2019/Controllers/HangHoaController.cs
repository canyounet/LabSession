using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D18_Session_23Apr2019.Models;
using Microsoft.AspNetCore.Mvc;

namespace D18_Session_23Apr2019.Controllers
{
    public class HangHoaController : Controller
    {
        public IActionResult Index()
        {
            //generate mock data
            Random rd = new Random();
            int N = rd.Next(10);//số lượng
            List<HangHoa> dsHangHoa = new List<HangHoa>();

            for(int i = 0; i < N; i++)
            {
                dsHangHoa.Add(new HangHoa {
                    HangHoaId = rd.Next(),
                    TenHangHoa = $"Random {Guid.NewGuid()}",
                    DonGia = rd.Next(100, 1000)
                });
            }
            return View(dsHangHoa);
        }
    }
}