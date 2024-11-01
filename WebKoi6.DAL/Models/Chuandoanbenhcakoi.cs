using System;
using System.Collections.Generic;

namespace WebKoi6.DAL.Models;

public partial class Chuandoanbenhcakoi
{
    public int Id { get; set; }
    public int LichhenId { get; set; }
    public DateTime? NgayThang { get; set; }

    public string? ChuanDoan { get; set; }

    public string? DauHieu { get; set; }

    public string? HinhThucDieuTri { get; set; }

    public string? TenLoaiCaKoi { get; set; }
}
