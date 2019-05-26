using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DAO
{
   public class KhaoThiView
    {
        public string TenLoaiKhaoThi { set; get; }
        public double TongSoGio { set; get; }
        public List<KhaoThiList> chiTiet { set; get; }
    }
}
