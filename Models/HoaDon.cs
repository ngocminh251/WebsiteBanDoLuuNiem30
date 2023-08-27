using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebsiteBanDoLuuNiem30.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }
        
        public int MaHoaDon { get; set; }
        
        public int MaKhachHang { get; set; }
        
        public int MaNhanVien { get; set; }
       
        public DateTime NgayLapHoaDon { get; set; }

        public virtual KhachHang MaKhachHangNavigation { get; set; }
        public virtual NhanVien MaNhanVienNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }

}
