using Microsoft.EntityFrameworkCore;

namespace MyWebApiApp.Data
{
    public class MyDbContext : DbContext 

    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        #region Dbset 
        public DbSet<HangHoa> HangHoas { get; set;}
        public DbSet<Loai> Loais { get; set;}
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set;} 
        public DbSet<DonHang> DonHangs { get; set;} 
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonHang>(e => { 
                e.ToTable("DonHang");
                e.HasKey(dh => dh.MaDonHang);
                e.Property(dh => dh.NgayDat).HasDefaultValueSql("getutcdate()");
                e.Property(dh => dh.ThongTinNguoiNhanHang).IsRequired().HasMaxLength(50);

            });
            modelBuilder.Entity<ChiTietDonHang>(e => {
                e.ToTable("ChiTietDonHang");
                e.HasKey(e => new {e.MaDonHang , e.MaHangHoa});

                e.HasOne(e => e.DonHang)
                .WithMany(e => e.ChiTietDonHangs)
                .HasForeignKey(e => e.MaDonHang)
                .HasConstraintName("FK_ChiTietDonHang_DonHang");

                e.HasOne(e => e.HangHoa)
                .WithMany(e => e.ChiTietDonHangs)
                .HasForeignKey(e => e.MaHangHoa)
                .HasConstraintName("FK_ChiTietDonHang_HangHoa"); 

            });
        }
    }
}
