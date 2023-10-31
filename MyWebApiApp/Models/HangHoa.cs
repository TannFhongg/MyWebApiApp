namespace MyWebApiApp.Models
{
    public class HangHoaVM
    {
        
        public string Name { get; set; }
        public double Price { get; set; } = 0;

    }
    public class HangHoa : HangHoaVM
    {
        public Guid Id { get; set; }
        
        

    }
    public class HangHoaModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; } = 0;

        public string TenLoaiHangHoa { get; set; }
    }
}
