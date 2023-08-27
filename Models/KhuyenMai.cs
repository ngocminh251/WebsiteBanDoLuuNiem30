using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebsiteBanDoLuuNiem30.Models
{
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }
       
        public string? MaGiamGia { get; set; }
        
        public decimal SoTienGiam { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }

}
