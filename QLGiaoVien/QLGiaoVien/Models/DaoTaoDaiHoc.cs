namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DaoTaoDaiHoc")]
    public partial class DaoTaoDaiHoc
    {
        public int id { get; set; }

        public int? GiaoVien_id { get; set; }

        [StringLength(255)]
        public string HeDaoTao { get; set; }

        [StringLength(255)]
        public string NganhDaoTao { get; set; }

        [StringLength(255)]
        public string NoiDaoTao { get; set; }

        [StringLength(50)]
        public string NuocDaoTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NamTotNghiep { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }
    }
}
