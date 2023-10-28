using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApiApp.Data
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public Guid MaHangHoa { get; set; }
        [Required]
        [MaxLength(50)]
        public string TenHangHoa { set; get; }
        [Range(0, double.MaxValue)]
        public double GiaTien { set; get; }
        public string MoTa { set; get; }
        public byte GiamGia { set; get; }
        public int? MaLoai { set; get; }
        [ForeignKey("MaLoai")]
        public Loai Loai { set; get; }
        public ICollection<ChiTietDonHang> ChiTietDonHangs { set; get; }
        public HangHoa()
        {
            ChiTietDonHangs = new List<ChiTietDonHang>();
        }
    }
}
