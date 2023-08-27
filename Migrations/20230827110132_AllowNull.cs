using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsiteBanDoLuuNiem30.Migrations
{
    /// <inheritdoc />
    public partial class AllowNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_CTHD_KM",
                table: "ChiTietHoaDon");

            migrationBuilder.AlterColumn<byte[]>(
                name: "HinhAnh",
                table: "SanPham",
                type: "image",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "image");

            migrationBuilder.AlterColumn<string>(
                name: "MieuTa",
                table: "Quyen",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MieuTa",
                table: "PhanLoaiSanPham",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HangThanhVien",
                table: "KhachHang",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "MaGiamGia",
                table: "ChiTietHoaDon",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddForeignKey(
                name: "fk_CTHD_KM",
                table: "ChiTietHoaDon",
                column: "MaGiamGia",
                principalTable: "KhuyenMai",
                principalColumn: "MaGiamGia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_CTHD_KM",
                table: "ChiTietHoaDon");

            migrationBuilder.AlterColumn<byte[]>(
                name: "HinhAnh",
                table: "SanPham",
                type: "image",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "image",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MieuTa",
                table: "Quyen",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MieuTa",
                table: "PhanLoaiSanPham",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HangThanhVien",
                table: "KhachHang",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaGiamGia",
                table: "ChiTietHoaDon",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_CTHD_KM",
                table: "ChiTietHoaDon",
                column: "MaGiamGia",
                principalTable: "KhuyenMai",
                principalColumn: "MaGiamGia",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
