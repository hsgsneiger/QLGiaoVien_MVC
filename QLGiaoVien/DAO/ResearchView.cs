using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class ResearchView
    {
        public string TenNhomNCKH { get; set; }
        public double TongSoGio { get; set; }
        public List<ResearchDaoForList> ChiTiet { get; set; }
    }
}
