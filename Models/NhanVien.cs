using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebsiteBanDoLuuNiem30.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
            TaiKhoans = new HashSet<TaiKhoan>();
        }
        
        public int MaNhanVien { get; set; }
        
        public string Ho { get; set; }
        
        public string Ten { get; set; }
       
        public DateTime NgaySinh { get; set; }
        
        public string GioiTinh { get; set; }
        
        public string ChucVu { get; set; }
       
        public decimal Luong { get; set; }
        
        public DateTime NgayLam { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }

}
