using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DAO
{
    public class KhaoThiList
    {
        public string TenKhaoThi { set; get; }
        public string TenLop { set; get; }
        public int SoBai { set; get; }
        public double SoGio { set; get; }
    }
}
