using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsiteBanDoLuuNiem30.Migrations
{
    /// <inheritdoc />
    public partial class DeleteProductImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HinhAnh",
                table: "SanPham");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "HinhAnh",
                table: "SanPham",
                type: "image",
                nullable: true);
        }
    }
}
