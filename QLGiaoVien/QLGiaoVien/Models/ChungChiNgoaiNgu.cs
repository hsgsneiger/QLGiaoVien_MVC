namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChungChiNgoaiNgu")]
    public partial class ChungChiNgoaiNgu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChungChiNgoaiNgu()
        {
            GiaoVien_ChungChiNgoaiNgu = new HashSet<GiaoVien_ChungChiNgoaiNgu>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string TenChungChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_ChungChiNgoaiNgu> GiaoVien_ChungChiNgoaiNgu { get; set; }
    }
}
