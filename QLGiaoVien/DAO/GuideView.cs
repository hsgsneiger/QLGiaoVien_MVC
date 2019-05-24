using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class GuideView
    {
        public string TenLoaiHuongDan { get; set; }
        public double SoGioDinhMuc { get; set; }
        public double TongSoGio { get; set; }

        public List<GuideDAOForList> ChiTiet { get; set; }

    }
}
