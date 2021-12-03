using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLBHDTDD.Models
{
    public class nv_hg
    {
        [Key]
        [DisplayName("ID Nhân viên giao hàng")]
        public int ID_nvgh { get; set; }
        [Required, DisplayName("Tên nhân viên giao hàng")]
        public string Ten_nvgh { get; set; }
        [Required, DisplayName("Số điện thoại thứ 1 của nhân viên giao hàng")]
        public string Sdt_1 { get; set; }
        [Required, DisplayName("Số điện thoại thứ 2 của nhân viên giao hàng")]
        public string Sdt_2 { get; set; }
        public ICollection<Don_dh> Don_dhs { get; set; }
    }
}