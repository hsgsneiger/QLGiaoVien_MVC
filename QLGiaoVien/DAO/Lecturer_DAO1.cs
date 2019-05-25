using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DAO
{
    /// <summary>
    /// Toanpn, using for task 1 2
    /// </summary>
    public class Lecturer_DAO1
    {
        public int id { get; set; }

        [Display(Name = "Bộ Môn")]
        public int BoMon_id { get; set; }

        [Display(Name = "Họ Tên")]
        public string HoTen { get; set; }

        [Display(Name = "Giới Tính")]
        public bool? GioiTinh { get; set; }

        [Display(Name = "Ngày Sinh")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(255)]
        [Display(Name = "Quê Quán")]
        public string QueQuan { get; set; }

        [Display(Name = "Xã/Phường")]
        [StringLength(50)]
        public string PhuongXa { get; set; }

        [Display(Name = "Quận/Huyện")]
        [StringLength(50)]
        public string QuanHuyen { get; set; }

        [Display(Name = "Tỉnh/Thành Phố")]
        [StringLength(50)]
        public string TinhThanhPho { get; set; }

        [Display(Name = "Điện thoại cố định")]
        [StringLength(20)]
        public string DienThoaiNR { get; set; }

        [Display(Name = "Điện thoại di động")]
        [StringLength(20)]
        public string DienThoaiDD { get; set; }

        [Display(Name = "Email")]
        [StringLength(50)]
        public string Email { get; set; }

        [Display(Name = "")]
        public bool? LaPhuNuCoConNho { get; set; }

        [Display(Name = "")]
        public DateTime? ThoiGianNghiViec { get; set; }
    }
}
