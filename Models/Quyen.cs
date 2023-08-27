using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebsiteBanDoLuuNiem30.Models
{
    public partial class Quyen
    {
        public Quyen()
        {
            TaiKhoans = new HashSet<TaiKhoan>();
        }
        
        public string MaQuyen { get; set; }
        
        public string TenQuyen { get; set; }
        public string? MieuTa { get; set; }

        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }

}
