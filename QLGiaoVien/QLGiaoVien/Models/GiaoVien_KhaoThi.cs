namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GiaoVien_KhaoThi
    {
        public int id { get; set; }

        public int? GiaoVien_id { get; set; }

        public int? KhaoThi_id { get; set; }

        public int? NamHoc_id { get; set; }

        public int? SoBai_SoSV { get; set; }

        public virtual GiaoVien_HocHamHocVi GiaoVien_HocHamHocVi { get; set; }

        public virtual KhaoThi KhaoThi { get; set; }

        public virtual NamHoc NamHoc { get; set; }
    }
}
