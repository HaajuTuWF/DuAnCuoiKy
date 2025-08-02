using Microsoft.AspNetCore.Mvc;

namespace ProjectFinal.Models
{
    public class Cart
    {
        public int? ID { get; set; }
        public string? TenSp { get; set; }
        public decimal? GiaSp { get; set; }
        public string? LinkAnh { get; set; }
        public int? SoLuong { get; set; } = 1;
    }

}
