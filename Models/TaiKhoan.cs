using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebsiteBanDoLuuNiem30.Models
{
    public partial class TaiKhoan
    {
        
        public string MaTaiKhoan { get; set; }
        
        public string MatKhau { get; set; }
        
        public string MaQuyen { get; set; }
        
        public int MaNhanVien { get; set; }

        public virtual NhanVien MaNhanVienNavigation { get; set; }
        public virtual Quyen MaQuyenNavigation { get; set; }
    }

}
