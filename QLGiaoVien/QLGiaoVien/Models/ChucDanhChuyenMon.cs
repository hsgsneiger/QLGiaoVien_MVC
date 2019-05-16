namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChucDanhChuyenMon")]
    public partial class ChucDanhChuyenMon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChucDanhChuyenMon()
        {
            DinhMucGiangDays = new HashSet<DinhMucGiangDay>();
            DinhMucNghienCuus = new HashSet<DinhMucNghienCuu>();
            GiaoVien_ChucDanhChuyenMon = new HashSet<GiaoVien_ChucDanhChuyenMon>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string TenChucDanh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DinhMucGiangDay> DinhMucGiangDays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DinhMucNghienCuu> DinhMucNghienCuus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_ChucDanhChuyenMon> GiaoVien_ChucDanhChuyenMon { get; set; }
    }
}
