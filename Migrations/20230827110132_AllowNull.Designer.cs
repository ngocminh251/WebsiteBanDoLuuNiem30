﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebsiteBanDoLuuNiem30.Models;

#nullable disable

namespace WebsiteBanDoLuuNiem30.Migrations
{
    [DbContext(typeof(WebsiteBanDoLuuNiem30Context))]
    [Migration("20230827110132_AllowNull")]
    partial class AllowNull
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.ChiTietHoaDon", b =>
                {
                    b.Property<int>("MaHoaDon")
                        .HasColumnType("int");

                    b.Property<int>("MaSanPham")
                        .HasColumnType("int");

                    b.Property<decimal>("GiaTien")
                        .HasColumnType("money");

                    b.Property<string>("MaGiamGia")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<decimal>("TongHoaDon")
                        .HasColumnType("money");

                    b.HasKey("MaHoaDon", "MaSanPham");

                    b.HasIndex("MaGiamGia");

                    b.HasIndex("MaSanPham");

                    b.ToTable("ChiTietHoaDon", (string)null);
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.HoaDon", b =>
                {
                    b.Property<int>("MaHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaHoaDon"));

                    b.Property<int>("MaKhachHang")
                        .HasColumnType("int");

                    b.Property<int>("MaNhanVien")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayLapHoaDon")
                        .HasColumnType("datetime");

                    b.HasKey("MaHoaDon")
                        .HasName("PK_HD");

                    b.HasIndex("MaKhachHang");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.KhachHang", b =>
                {
                    b.Property<int>("MaKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaKhachHang"));

                    b.Property<string>("HangThanhVien")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaKhachHang")
                        .HasName("PK_KH");

                    b.ToTable("KhachHang", (string)null);
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.KhuyenMai", b =>
                {
                    b.Property<string>("MaGiamGia")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("SoTienGiam")
                        .HasColumnType("money");

                    b.HasKey("MaGiamGia");

                    b.ToTable("KhuyenMai", (string)null);
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.NhanVien", b =>
                {
                    b.Property<int>("MaNhanVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaNhanVien"));

                    b.Property<string>("ChucVu")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ho")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Luong")
                        .HasColumnType("money");

                    b.Property<DateTime>("NgayLam")
                        .HasColumnType("date");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("MaNhanVien")
                        .HasName("PK_NV");

                    b.ToTable("NhanVien", (string)null);
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.PhanLoaiSanPham", b =>
                {
                    b.Property<int>("MaLoaiSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLoaiSanPham"));

                    b.Property<string>("MieuTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLoaiSanPham")
                        .HasName("PK_PLSP");

                    b.ToTable("PhanLoaiSanPham", (string)null);
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.Quyen", b =>
                {
                    b.Property<string>("MaQuyen")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MieuTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenQuyen")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaQuyen");

                    b.ToTable("Quyen", (string)null);
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.SanPham", b =>
                {
                    b.Property<int>("MaSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaSanPham"));

                    b.Property<decimal>("Gia")
                        .HasColumnType("money");

                    b.Property<byte[]>("HinhAnh")
                        .HasColumnType("image");

                    b.Property<int>("MaLoaiSanPham")
                        .HasColumnType("int");

                    b.Property<int?>("SoLuongDatHang")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongTrongKho")
                        .HasColumnType("int");

                    b.Property<string>("TenSanPham")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaSanPham")
                        .HasName("PK_SP");

                    b.HasIndex("MaLoaiSanPham");

                    b.ToTable("SanPham", (string)null);
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.TaiKhoan", b =>
                {
                    b.Property<string>("MaTaiKhoan")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("MaNhanVien")
                        .HasColumnType("int");

                    b.Property<string>("MaQuyen")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTaiKhoan")
                        .HasName("PK_TK");

                    b.HasIndex("MaNhanVien");

                    b.HasIndex("MaQuyen");

                    b.ToTable("TaiKhoan", (string)null);
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.ChiTietHoaDon", b =>
                {
                    b.HasOne("WebsiteBanDoLuuNiem30.Models.KhuyenMai", "MaGiamGiaNavigation")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("MaGiamGia")
                        .HasConstraintName("fk_CTHD_KM");

                    b.HasOne("WebsiteBanDoLuuNiem30.Models.HoaDon", "MaHoaDonNavigation")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("MaHoaDon")
                        .IsRequired()
                        .HasConstraintName("FK_CTHD_HD");

                    b.HasOne("WebsiteBanDoLuuNiem30.Models.SanPham", "MaSanPhamNavigation")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("MaSanPham")
                        .IsRequired()
                        .HasConstraintName("FK_CTHD_SP");

                    b.Navigation("MaGiamGiaNavigation");

                    b.Navigation("MaHoaDonNavigation");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.HoaDon", b =>
                {
                    b.HasOne("WebsiteBanDoLuuNiem30.Models.KhachHang", "MaKhachHangNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaKhachHang")
                        .IsRequired()
                        .HasConstraintName("FK_HD_KH");

                    b.HasOne("WebsiteBanDoLuuNiem30.Models.NhanVien", "MaNhanVienNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaNhanVien")
                        .IsRequired()
                        .HasConstraintName("FK_HD_NV");

                    b.Navigation("MaKhachHangNavigation");

                    b.Navigation("MaNhanVienNavigation");
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.SanPham", b =>
                {
                    b.HasOne("WebsiteBanDoLuuNiem30.Models.PhanLoaiSanPham", "MaLoaiSanPhamNavigation")
                        .WithMany("SanPhams")
                        .HasForeignKey("MaLoaiSanPham")
                        .IsRequired()
                        .HasConstraintName("FK_SP_PLSP");

                    b.Navigation("MaLoaiSanPhamNavigation");
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.TaiKhoan", b =>
                {
                    b.HasOne("WebsiteBanDoLuuNiem30.Models.NhanVien", "MaNhanVienNavigation")
                        .WithMany("TaiKhoans")
                        .HasForeignKey("MaNhanVien")
                        .IsRequired()
                        .HasConstraintName("FK_TK_NV");

                    b.HasOne("WebsiteBanDoLuuNiem30.Models.Quyen", "MaQuyenNavigation")
                        .WithMany("TaiKhoans")
                        .HasForeignKey("MaQuyen")
                        .IsRequired()
                        .HasConstraintName("FK_TK_Q");

                    b.Navigation("MaNhanVienNavigation");

                    b.Navigation("MaQuyenNavigation");
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.HoaDon", b =>
                {
                    b.Navigation("ChiTietHoaDons");
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.KhuyenMai", b =>
                {
                    b.Navigation("ChiTietHoaDons");
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.NhanVien", b =>
                {
                    b.Navigation("HoaDons");

                    b.Navigation("TaiKhoans");
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.PhanLoaiSanPham", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.Quyen", b =>
                {
                    b.Navigation("TaiKhoans");
                });

            modelBuilder.Entity("WebsiteBanDoLuuNiem30.Models.SanPham", b =>
                {
                    b.Navigation("ChiTietHoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
