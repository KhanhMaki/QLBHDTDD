using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLBHDTDD.Models
{
    public class Danhmuc_sp
    {
        [Key]
        [DisplayName("ID Danh mục")]
        public int ID_dm { get; set; }
        [Required, DisplayName("Tên danh mục")]
        public string Ten_danhmuc { get; set; }
        public ICollection<SanPham> SanPhams { get; set; }
    }
}