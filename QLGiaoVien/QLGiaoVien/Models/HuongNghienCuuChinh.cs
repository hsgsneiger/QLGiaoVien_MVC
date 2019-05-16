namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HuongNghienCuuChinh")]
    public partial class HuongNghienCuuChinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HuongNghienCuuChinh()
        {
            GiaoVien_HuongNghienCuu = new HashSet<GiaoVien_HuongNghienCuu>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string TenHuongNghienCuu { get; set; }

        public string NoiDungHuongNghienCuu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_HuongNghienCuu> GiaoVien_HuongNghienCuu { get; set; }
    }
}
