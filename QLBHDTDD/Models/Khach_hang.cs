using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLBHDTDD.Models
{
    public class Khach_hang
    {
        [Key]
        [DisplayName("ID Khách hàng")]
        public int ID_kh { get; set; }
        [Required, DisplayName("Tên khách hàng")]
        public string Ten_kh { get; set; }
        [Required, DisplayName("Số điện thoại khách hàng")]
        public string Sdt { get; set; }
        [Required, DisplayName("E-mail khách hàng")]
        public string Email { get; set; }
        public ICollection<Don_dh> Don_dhs { get; set; }
    }
}