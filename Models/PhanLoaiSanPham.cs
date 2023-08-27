using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebsiteBanDoLuuNiem30.Models
{
    public partial class PhanLoaiSanPham
    {
        public PhanLoaiSanPham()
        {
            SanPhams = new HashSet<SanPham>();
        }
        
        public int MaLoaiSanPham { get; set; }
        
        public string TenLoai { get; set; }
        public string? MieuTa { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }

}
