namespace MyWebApiApp.Data
{
    public enum TinhTrangDonDatHang
    {
        New = 0 , Payment = 1 , Complete = 2 , Cancelled = 3 
    }
    public class DonHang
    {
        public Guid MaDonHang {  get; set; }
        public  DateTime NgayDat { get; set; }
        public DateTime NgayGiao { get; set; }
        public TinhTrangDonDatHang TinhTrangDonHang { get;set; }
        public string ThongTinNguoiNhanHang { get; set; }   
        public string DiaChiGiaoHang { get; set; } 
        public string SoDienThoai {  get; set; }

        public ICollection<ChiTietDonHang> ChiTietDonHangs { set; get; }
        public DonHang()
        {
            ChiTietDonHangs = new List<ChiTietDonHang>();
        }
    }
}
