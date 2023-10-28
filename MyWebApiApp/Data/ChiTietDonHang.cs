using System.ComponentModel.DataAnnotations;

namespace MyWebApiApp.Data
{
    public class ChiTietDonHang
        
    {
        [Key]
        public Guid MaHangHoa { get; set; }
        [Key]
        public Guid MaDonHang { get; set; }

        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public double GiamGia { get; set; }
        
        //relationship
        public DonHang DonHang { get; set; } 
        public HangHoa HangHoa { get; set; }

    }
}
