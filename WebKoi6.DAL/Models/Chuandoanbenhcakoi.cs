using System;
using System.Collections.Generic;

namespace WebKoi6.DAL.Models;

public partial class Chuandoanbenhcakoi
{
    public int Id { get; set; }

    public string? TenKhachHang { get; set; }

    public string? SoDienThoai { get; set; }

    public string? Email { get; set; }

    public string? NgayThang { get; set; }

    public string? ChuanDoan { get; set; }

    public string? DauHieu { get; set; }

    public string? HinhThucDieuTri { get; set; }

    public string? TenLoaiCaKoi { get; set; }
}
