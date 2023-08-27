using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebsiteBanDoLuuNiem30.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        
        public int MaKhachHang { get; set; }
        
        public string TenKhachHang { get; set; }
       
        public string SoDienThoai { get; set; }
        public string? HangThanhVien { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
