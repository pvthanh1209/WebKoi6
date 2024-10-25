using System;
using System.Collections.Generic;

namespace WebKoi6.DAL.Models;

public partial class Lichhen
{
    public string? TenKhachHang { get; set; }

    public string? TenBacSi { get; set; }

    public DateTime? NgayHen { get; set; }

    public string? TrangThai { get; set; }

    public ulong HomeVisit { get; set; }
}
