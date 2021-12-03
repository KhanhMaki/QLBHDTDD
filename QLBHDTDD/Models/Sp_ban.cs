using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLBHDTDD.Models
{
    public class Sp_ban
    {
        [Key]
        [DisplayName("ID Sản phẩm bán")]
        public int ID_sp_ban { get; set; }
        [Required, DisplayName("ID Sản phẩm")]
        public int ID_sp { get; set; }
        [Required, DisplayName("Số lượng bán")]
        public int So_luong_ban { get; set; }
        public virtual SanPham SanPhams { get; set; }
}
}