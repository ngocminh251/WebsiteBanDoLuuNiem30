using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebsiteBanDoLuuNiem30.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }
        
        public int MaSanPham { get; set; }
        
        public int MaLoaiSanPham { get; set; }
        
        public string TenSanPham { get; set; }
        
        public decimal Gia { get; set; }
        
        public int SoLuongTrongKho { get; set; }
        public int? SoLuongDatHang { get; set; }

        public virtual PhanLoaiSanPham MaLoaiSanPhamNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }

}
