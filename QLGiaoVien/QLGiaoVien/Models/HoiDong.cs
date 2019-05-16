namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoiDong")]
    public partial class HoiDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoiDong()
        {
            GiaoVien_HoiDong = new HashSet<GiaoVien_HoiDong>();
        }

        public int id { get; set; }

        public int LoaiHoiDong_id { get; set; }

        [StringLength(255)]
        public string TenHoiDong { get; set; }

        public double? SoGioQuyDoi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_HoiDong> GiaoVien_HoiDong { get; set; }

        public virtual LoaiHoiDong LoaiHoiDong { get; set; }
    }
}
