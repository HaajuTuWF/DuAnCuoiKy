using System.ComponentModel.DataAnnotations;

namespace ProjectFinal.Models
{
    public class AnhAcerAP7
    {
        [Key]
        public int ID { get; set; }
        public string? Anh1 { get; set; } = string.Empty;
        public string? Anh2 { get; set; } = string.Empty;
        public string? Anh3 { get; set; } = string.Empty;
        public string? Anh4 { get; set; } = string.Empty;
        public string? Anh5 { get; set; } = string.Empty;
    }
}
