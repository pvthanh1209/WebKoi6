using System;
using System.Collections.Generic;

namespace WebKoi6.DAL.Models;

public partial class Thuoc
{
    public int MaThuoc { get; set; }

    public string? TenThuoc { get; set; }

    public string? CongDung { get; set; }

    public string? LieuLuong { get; set; }

    public string? GhiChu { get; set; }

    public decimal Gia { get; set; }
}
