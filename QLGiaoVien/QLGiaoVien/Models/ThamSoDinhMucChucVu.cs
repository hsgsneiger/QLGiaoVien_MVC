namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThamSoDinhMucChucVu")]
    public partial class ThamSoDinhMucChucVu
    {
        public int id { get; set; }

        public short? SoCanBoApDungDinhMucCao { get; set; }

        public short? SoCanBoApDungDinhMucThap { get; set; }

        [StringLength(10)]
        public string TiL { get; set; }
    }
}
