using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLBHDTDD.Models
{
    public partial class DBconnect : DbContext
    {
        public DBconnect()
            : base("name=DBconnect")
        {
        }
        public DbSet <SanPham> SanPhams { get; set; }
        public DbSet<Don_dh> Don_Dhs { get; set; }
        public DbSet<Chitiet_dh> Chitiet_Dhs { get; set; }
        public DbSet<Danhgia> Danhgias { get; set; }
        public DbSet<Danhmuc_sp> Danhmuc_Sps { get; set; }
        public DbSet<Khach_hang> Khach_Hangs { get; set; }
        public DbSet<Nguoi_dung> Nguoi_Dungs { get; set; }
        public DbSet<nv_hg> nv_hgs { get; set; }
        public DbSet<Sp_ban> Sp_Bans { get; set; }
        public DbSet<Tinh_trang> Tinh_Trangs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
