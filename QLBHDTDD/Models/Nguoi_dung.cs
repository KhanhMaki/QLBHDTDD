using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLBHDTDD.Models
{
    public class Nguoi_dung
    {
        [Key]
        [DisplayName("ID Người dùng")]
        public int ID_nd { get; set; }
        [Required, DisplayName("Tài khoản")]
        public string ID { get; set; }
        [Required, DisplayName("Mật khẩu")]
        public string Pass { get; set; }
        [Required, DisplayName("Tên người dùng")]
        public string Ten { get; set; }
    }
}