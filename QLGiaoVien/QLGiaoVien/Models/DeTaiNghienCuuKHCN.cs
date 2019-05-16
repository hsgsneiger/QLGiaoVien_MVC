namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeTaiNghienCuuKHCN")]
    public partial class DeTaiNghienCuuKHCN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeTaiNghienCuuKHCN()
        {
            GiaoVien_DeTaiNghienCuuKHCN = new HashSet<GiaoVien_DeTaiNghienCuuKHCN>();
        }

        public int id { get; set; }

        public int NhomNCKH_id { get; set; }

        [StringLength(255)]
        public string TenDeTai { get; set; }

        [StringLength(255)]
        public string CapQuanLy { get; set; }

        public byte? SoTacGia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianBatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianKetThuc { get; set; }

        [StringLength(255)]
        public string CoQuanQuanLy { get; set; }

        public bool? DaNghiemThu { get; set; }

        public int? LoaiDeTai_id { get; set; }

        public int? VaiTro_id { get; set; }

        public double? SoTrang { get; set; }

        public virtual NhomNCKH NhomNCKH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_DeTaiNghienCuuKHCN> GiaoVien_DeTaiNghienCuuKHCN { get; set; }
    }
}
