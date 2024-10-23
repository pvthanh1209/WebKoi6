using System;
using System.Collections.Generic;

namespace WebKoi6.DAL.Models;

public partial class Chuandoantinhtrangnuoc
{
    public int Id { get; set; }

    public string? TenKhachHang { get; set; }

    public string? SoDienThoai { get; set; }

    public string? Email { get; set; }

    public DateOnly? NgayThang { get; set; }

    public decimal? Ph { get; set; }

    public decimal? DoCuongNuoc { get; set; }

    public decimal? NhietDo { get; set; }

    public string? TinhTrang { get; set; }
}
