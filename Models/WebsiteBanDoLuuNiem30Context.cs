using Microsoft.EntityFrameworkCore;

namespace WebsiteBanDoLuuNiem30.Models
{
    public partial class WebsiteBanDoLuuNiem30Context : DbContext
    {
        public WebsiteBanDoLuuNiem30Context()
        {
        }

        public WebsiteBanDoLuuNiem30Context(DbContextOptions<WebsiteBanDoLuuNiem30Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhanLoaiSanPham> PhanLoaiSanPhams { get; set; }
        public virtual DbSet<Quyen> Quyens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.HasKey(e => new { e.MaHoaDon, e.MaSanPham });

                entity.ToTable("ChiTietHoaDon");

                entity.Property(e => e.GiaTien).HasColumnType("money");

                entity.Property(e => e.MaGiamGia).HasMaxLength(10);

                entity.Property(e => e.TongHoaDon).HasColumnType("money");

                entity.HasOne(d => d.MaGiamGiaNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaGiamGia)
                    .HasConstraintName("fk_CTHD_KM");

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTHD_HD");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTHD_SP");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK_HD");

                entity.ToTable("HoaDon");

                entity.Property(e => e.NgayLapHoaDon).HasColumnType("datetime");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HD_KH");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaNhanVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HD_NV");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKhachHang)
                    .HasName("PK_KH");

                entity.ToTable("KhachHang");

                entity.Property(e => e.HangThanhVien).HasMaxLength(50);

                entity.Property(e => e.SoDienThoai)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TenKhachHang)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.HasKey(e => e.MaGiamGia);

                entity.ToTable("KhuyenMai");

                entity.Property(e => e.MaGiamGia).HasMaxLength(10);

                entity.Property(e => e.SoTienGiam).HasColumnType("money");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK_NV");

                entity.ToTable("NhanVien");

                entity.Property(e => e.ChucVu)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.GioiTinh).HasMaxLength(10);

                entity.Property(e => e.Ho)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Luong).HasColumnType("money");

                entity.Property(e => e.NgayLam).HasColumnType("date");

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<PhanLoaiSanPham>(entity =>
            {
                entity.HasKey(e => e.MaLoaiSanPham)
                    .HasName("PK_PLSP");

                entity.ToTable("PhanLoaiSanPham");

                entity.Property(e => e.TenLoai).IsRequired();
            });

            modelBuilder.Entity<Quyen>(entity =>
            {
                entity.HasKey(e => e.MaQuyen);

                entity.ToTable("Quyen");

                entity.Property(e => e.MaQuyen).HasMaxLength(10);

                entity.Property(e => e.TenQuyen)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("PK_SP");

                entity.ToTable("SanPham");

                entity.Property(e => e.Gia).HasColumnType("money");

                entity.Property(e => e.TenSanPham).IsRequired();

                entity.HasOne(d => d.MaLoaiSanPhamNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaLoaiSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SP_PLSP");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.MaTaiKhoan)
                    .HasName("PK_TK");

                entity.ToTable("TaiKhoan");

                entity.Property(e => e.MaTaiKhoan).HasMaxLength(20);

                entity.Property(e => e.MaQuyen)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.MatKhau).IsRequired();

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.TaiKhoans)
                    .HasForeignKey(d => d.MaNhanVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TK_NV");

                entity.HasOne(d => d.MaQuyenNavigation)
                    .WithMany(p => p.TaiKhoans)
                    .HasForeignKey(d => d.MaQuyen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TK_Q");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

