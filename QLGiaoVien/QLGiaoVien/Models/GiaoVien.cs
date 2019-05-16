namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaoVien")]
    public partial class GiaoVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiaoVien()
        {
            DaoTaoDaiHocs = new HashSet<DaoTaoDaiHoc>();
            GiaoVien_ChucDanhChuyenMon = new HashSet<GiaoVien_ChucDanhChuyenMon>();
            GiaoVien_ChucVu = new HashSet<GiaoVien_ChucVu>();
            GiaoVien_ChungChiNgoaiNgu = new HashSet<GiaoVien_ChungChiNgoaiNgu>();
            GiaoVien_DeTaiNghienCuuKHCN = new HashSet<GiaoVien_DeTaiNghienCuuKHCN>();
            GiaoVien_GiangDay = new HashSet<GiaoVien_GiangDay>();
            GiaoVien_HocHamHocVi = new HashSet<GiaoVien_HocHamHocVi>();
            GiaoVien_HoiDong = new HashSet<GiaoVien_HoiDong>();
            GiaoVien_HuongDan = new HashSet<GiaoVien_HuongDan>();
            GiaoVien_HuongNghienCuu = new HashSet<GiaoVien_HuongNghienCuu>();
            KhenThuongs = new HashSet<KhenThuong>();
            KyLuats = new HashSet<KyLuat>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int BoMon_id { get; set; }

        [StringLength(255)]
        public string HoTen { get; set; }

        public bool? GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(255)]
        public string QueQuan { get; set; }

        [StringLength(50)]
        public string PhuongXa { get; set; }

        [StringLength(50)]
        public string QuanHuyen { get; set; }

        [StringLength(50)]
        public string TinhThanhPho { get; set; }

        [StringLength(20)]
        public string DienThoaiNR { get; set; }

        [StringLength(20)]
        public string DienThoaiDD { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public bool? LaPhuNuCoConNho { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianNghiViec { get; set; }

        public virtual BoMon BoMon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaoTaoDaiHoc> DaoTaoDaiHocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_ChucDanhChuyenMon> GiaoVien_ChucDanhChuyenMon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_ChucVu> GiaoVien_ChucVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_ChungChiNgoaiNgu> GiaoVien_ChungChiNgoaiNgu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_DeTaiNghienCuuKHCN> GiaoVien_DeTaiNghienCuuKHCN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_GiangDay> GiaoVien_GiangDay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_HocHamHocVi> GiaoVien_HocHamHocVi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_HoiDong> GiaoVien_HoiDong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_HuongDan> GiaoVien_HuongDan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_HuongNghienCuu> GiaoVien_HuongNghienCuu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhenThuong> KhenThuongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KyLuat> KyLuats { get; set; }
    }
}
