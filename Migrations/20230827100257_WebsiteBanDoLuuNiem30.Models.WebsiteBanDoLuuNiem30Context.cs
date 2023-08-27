using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsiteBanDoLuuNiem30.Migrations
{
    /// <inheritdoc />
    public partial class WebsiteBanDoLuuNiem30ModelsWebsiteBanDoLuuNiem30Context : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKhachHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhachHang = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HangThanhVien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KH", x => x.MaKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMai",
                columns: table => new
                {
                    MaGiamGia = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SoTienGiam = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMai", x => x.MaGiamGia);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNhanVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "date", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ChucVu = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Luong = table.Column<decimal>(type: "money", nullable: false),
                    NgayLam = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NV", x => x.MaNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "PhanLoaiSanPham",
                columns: table => new
                {
                    MaLoaiSanPham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MieuTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLSP", x => x.MaLoaiSanPham);
                });

            migrationBuilder.CreateTable(
                name: "Quyen",
                columns: table => new
                {
                    MaQuyen = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenQuyen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MieuTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quyen", x => x.MaQuyen);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHoaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKhachHang = table.Column<int>(type: "int", nullable: false),
                    MaNhanVien = table.Column<int>(type: "int", nullable: false),
                    NgayLapHoaDon = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HD", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK_HD_KH",
                        column: x => x.MaKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "MaKhachHang");
                    table.ForeignKey(
                        name: "FK_HD_NV",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSanPham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLoaiSanPham = table.Column<int>(type: "int", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<decimal>(type: "money", nullable: false),
                    SoLuongTrongKho = table.Column<int>(type: "int", nullable: false),
                    SoLuongDatHang = table.Column<int>(type: "int", nullable: true),
                    HinhAnh = table.Column<byte[]>(type: "image", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP", x => x.MaSanPham);
                    table.ForeignKey(
                        name: "FK_SP_PLSP",
                        column: x => x.MaLoaiSanPham,
                        principalTable: "PhanLoaiSanPham",
                        principalColumn: "MaLoaiSanPham");
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    MaTaiKhoan = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaQuyen = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaNhanVien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TK", x => x.MaTaiKhoan);
                    table.ForeignKey(
                        name: "FK_TK_NV",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien");
                    table.ForeignKey(
                        name: "FK_TK_Q",
                        column: x => x.MaQuyen,
                        principalTable: "Quyen",
                        principalColumn: "MaQuyen");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    MaHoaDon = table.Column<int>(type: "int", nullable: false),
                    MaSanPham = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaTien = table.Column<decimal>(type: "money", nullable: false),
                    MaGiamGia = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TongHoaDon = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => new { x.MaHoaDon, x.MaSanPham });
                    table.ForeignKey(
                        name: "FK_CTHD_HD",
                        column: x => x.MaHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "MaHoaDon");
                    table.ForeignKey(
                        name: "FK_CTHD_SP",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham");
                    table.ForeignKey(
                        name: "fk_CTHD_KM",
                        column: x => x.MaGiamGia,
                        principalTable: "KhuyenMai",
                        principalColumn: "MaGiamGia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_MaGiamGia",
                table: "ChiTietHoaDon",
                column: "MaGiamGia");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_MaSanPham",
                table: "ChiTietHoaDon",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaKhachHang",
                table: "HoaDon",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaNhanVien",
                table: "HoaDon",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaLoaiSanPham",
                table: "SanPham",
                column: "MaLoaiSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_MaNhanVien",
                table: "TaiKhoan",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_MaQuyen",
                table: "TaiKhoan",
                column: "MaQuyen");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhuyenMai");

            migrationBuilder.DropTable(
                name: "Quyen");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "PhanLoaiSanPham");
        }
    }
}
