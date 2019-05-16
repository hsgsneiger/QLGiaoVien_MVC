namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HuongDan")]
    public partial class HuongDan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HuongDan()
        {
            GiaoVien_HuongDan = new HashSet<GiaoVien_HuongDan>();
        }

        public int id { get; set; }

        public int LoaiHuongDan_id { get; set; }

        [StringLength(255)]
        public string TenDeTai_ChuyenDe { get; set; }

        [StringLength(255)]
        public string HoTenHocVien { get; set; }

        [StringLength(50)]
        public string Lop { get; set; }

        public int? HeHuongDan_id { get; set; }

        public int? DaBaoVeThanhCong { get; set; }

        [StringLength(255)]
        public string CoQuanCongTacHocVien { get; set; }

        [StringLength(255)]
        public string DiaChiLienHeXacMinh { get; set; }

        public double? SoGioHuongDan { get; set; }

        public byte? SoCBHD { get; set; }

        public double? SoGio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_HuongDan> GiaoVien_HuongDan { get; set; }

        public virtual HeHuongDan HeHuongDan { get; set; }

        public virtual LoaiHuongDan LoaiHuongDan { get; set; }
    }
}
