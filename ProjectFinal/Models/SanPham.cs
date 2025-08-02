using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace ProjectFinal.Models;

public partial class SanPham
{
    public int ID { get; set; }

    public string? TenSp { get; set; }

    public decimal? GiaSp { get; set; }

    public string? LinkAnh { get; set; }

    public string? CauHinh1 { get; set; }
    public string? CauHinh2 { get; set; }
}
