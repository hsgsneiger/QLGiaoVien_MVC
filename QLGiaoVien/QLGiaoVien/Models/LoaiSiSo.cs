namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiSiSo")]
    public partial class LoaiSiSo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiSiSo()
        {
            GiangDays = new HashSet<GiangDay>();
        }

        public int id { get; set; }

        public int? NhomGiangDay_id { get; set; }

        [StringLength(255)]
        public string TenLoaiSiSo { get; set; }

        public double? QuyDoiGioChuan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiangDay> GiangDays { get; set; }

        public virtual NhomGiangDay NhomGiangDay { get; set; }
    }
}
