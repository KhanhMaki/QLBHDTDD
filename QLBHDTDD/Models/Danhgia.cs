using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLBHDTDD.Models
{
    public class Danhgia
    {
        [Key]
        [DisplayName("ID Đánh giá")]
        public int ID_dg { get; set; }
        [Required, DisplayName("ID Sản phẩm")]
        public int ID_sp { get; set; }
        [Required, DisplayName("Họ tên người đánh giá")]
        public string Ho_ten { get; set; }
        [Required, DisplayName("Ngày giờ đánh giá")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ngay_gio { get; set; }
        [Required, DisplayName("Nội dung đánh giá")]
        public string Noi_dung { get; set; }
        [Required, DisplayName("Điện thoại người đánh giá")]
        public string Dien_thoai { get; set; }
        public virtual SanPham SanPhams { get; set; }
}
}