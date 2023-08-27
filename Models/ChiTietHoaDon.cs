using System.ComponentModel.DataAnnotations;

namespace WebsiteBanDoLuuNiem30.Models
{
    public partial class ChiTietHoaDon
    {
        
        public int MaHoaDon { get; set; }
        
        public int MaSanPham { get; set; }
        
        public int SoLuong { get; set; }
        
        public decimal GiaTien { get; set; }
        public string? MaGiamGia { get; set; }
        
        public decimal TongHoaDon { get; set; }

        public virtual KhuyenMai MaGiamGiaNavigation { get; set; }
        public virtual HoaDon MaHoaDonNavigation { get; set; }
        public virtual SanPham MaSanPhamNavigation { get; set; }
    }

}
