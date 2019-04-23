using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D18_Session_23Apr2019.Models
{
    public static class DemoExtensionMethod
    {
        //thêm vào lớp DateTime method TinhKhoangCanhNgay()
        public static int TinhKhoangCanhNgay(this DateTime d1, DateTime d2)
        {
            return Math.Abs( (d1 - d2).Days);
        }

        //thêm hàm TongN() vào lớp int (trả về giá trị tổng N số nguyên đầu tiên
        public static int TongN(this int N)
        {
            int S = 0;
            for (int i = 1; i <= N; i++) S += i;
            return S;
        }
    }
}
