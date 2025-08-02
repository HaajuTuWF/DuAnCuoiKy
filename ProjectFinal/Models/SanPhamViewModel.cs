namespace ProjectFinal.Models
{
    public class SanPhamViewModel
    {
        public SanPham SanPham { get; set; }
        public int? ID { get; set; }

        public string? TenSp { get; set; }

        public decimal? GiaSp { get; set; }

        public string? LinkAnh { get; set; }

        public string? CauHinh1 { get; set; }
        public string? CauHinh2 { get; set; }
    }
}
