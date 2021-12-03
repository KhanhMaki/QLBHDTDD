using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLBHDTDD.Models
{
    public class SanPham
    {
        [Key]
        [DisplayName("ID Sản phẩm")]
        public int ID_sp { get; set; }
        [Required, DisplayName("ID Danh mục")]
        public string ID_dm { get; set; }
        [Required, DisplayName("Tên sản phẩm")]
        public string Ten_sp { get; set; }
        [Required, DisplayName("Ảnh sản phẩm")]
        public string Anh_sp { get; set; }
        [Required, DisplayName("Giá sản phẩm")]
        public int Gia_sp { get; set; }
        [Required, DisplayName("Số lượng sản phẩm")]
        public int So_luong { get; set; }
        [Required, DisplayName("Kích thước sản phẩm")]
        public string Kich_thuoc { get; set; }
        [Required, DisplayName("Màu sắc sản phẩm")]
        public string Mau_sac { get; set; }
        [Required, DisplayName("Bộ nhớ máy")]
        public string Bo_nho { get; set; }
        [Required, DisplayName("Thời gian bảo hành")]
        public string Bao_hanh { get; set; }
        [Required, DisplayName("Giá khuyến mãi")]
        public string Gia_km { get; set; }
        [Required, DisplayName("Ngày bắt đầu khuyến mãi")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Batdau_km { get; set; }
        [Required, DisplayName("Ngày kết thúc khuyến mãi")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ketthuc_km { get; set; }
        public ICollection <Sp_ban> Sp_bans { get; set; }
        public ICollection <Chitiet_dh> Chitiet_dhs { get; set; }
        public ICollection <Danhgia> Danhgias { get; set; }
        public virtual Danhmuc_sp Danhmuc_sps { get; set; }
}
}