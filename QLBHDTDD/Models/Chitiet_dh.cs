using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLBHDTDD.Models
{
    public class Chitiet_dh
    {
        [Key]
        [DisplayName("ID chi tiết hoá đơn")]
        public int ID_ct_hd { get; set; }
        [Required, DisplayName("ID Hoá đơn")]
        public int ID_hd { get; set; }
        [Required, DisplayName("ID Sản phẩm")]
        public int ID_sp { get; set; }
        [Required, DisplayName("Số lượng mỗi sản phẩm trong hoá đơn")]
        public int So_luong_mua { get; set; }
        [Required, DisplayName("Giá mỗi loại sản phẩm khi mua")]
        public int Don_gia { get; set; }
        public virtual SanPham SanPhams { get; set; }
        public  virtual Don_dh Don_dhs { get; set; }
}
}