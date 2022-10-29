namespace QuanLyDanhBa.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nguoi")]
    public partial class Nguoi
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TenGoi { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(1000)]
        public string DiaChi { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public int? IDNhom { get; set; }

        public virtual Nhom Nhom { get; set; }
    }
}
