using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D18_Session_23Apr2019.Models;
using Microsoft.AspNetCore.Mvc;

namespace D18_Session_23Apr2019.Controllers
{
    public class CartController : Controller
    {
        public List<CartItem> Cart => HttpContext.Session.Get<List<CartItem>>("GioHang");

        public IActionResult AddToCart(int id)
        {
            //kiếm trong session đã có hàng hóa có mã id?
            List<CartItem> gioHang = Cart;
            if (gioHang == null)
                gioHang = new List<CartItem>();

            //xử lý
            CartItem item = gioHang.SingleOrDefault(p => p.HangMua.HangHoaId == id);
            if(item != null)//đã có
            {
                item.SoLuong++;
            }
            else
            {
                Random rd = new Random();
                item = new CartItem
                {
                    HangMua = new HangHoa
                    {
                        HangHoaId = id,
                        DonGia = rd.Next(100, 1000),
                        TenHangHoa = $"Samsung S{rd.Next(10, 19)}"
                    },
                    SoLuong = 1
                };

                gioHang.Add(item);
            }
            //lưu session
            HttpContext.Session.Set("GioHang", gioHang);

            //chuyen den action xem gio hang
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View(Cart);
        }
    }
}