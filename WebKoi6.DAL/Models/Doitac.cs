using System;
using System.Collections.Generic;

namespace WebKoi6.DAL.Models;

public partial class Doitac
{
    public int MaDoiTac { get; set; }

    public string TenDoiTac { get; set; } = null!;

    public string? LoaiHinhHopTac { get; set; }

    public string? DiaChi { get; set; }

    public string? SoDienThoai { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public string? GhiChu { get; set; }
}
