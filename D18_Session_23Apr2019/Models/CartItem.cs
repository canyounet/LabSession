using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D18_Session_23Apr2019.Models
{
    /// <summary>
    /// Một dòng của giỏ hàng
    /// </summary>
    public class CartItem
    {
        public HangHoa HangMua { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien => SoLuong * HangMua.DonGia;
    }

    //public class CartHelper
    //{
    //    public static List<CartItem> Cart
    //    {
    //        get { }
    //        set {

    //        }
    //    }
    //}
}
