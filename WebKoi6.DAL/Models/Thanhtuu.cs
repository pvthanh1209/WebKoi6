using System;
using System.Collections.Generic;

namespace WebKoi6.DAL.Models;

public partial class Thanhtuu
{
    public int MaThanhTuu { get; set; }

    public string TenThanhTuu { get; set; } = null!;

    public string? MoTa { get; set; }

    public DateOnly? NgayDatDuoc { get; set; }

    public string? GhiChu { get; set; }
}
