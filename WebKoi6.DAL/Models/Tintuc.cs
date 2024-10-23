using System;
using System.Collections.Generic;

namespace WebKoi6.DAL.Models;

public partial class Tintuc
{
    public int MaTinTuc { get; set; }

    public string? TieuDe { get; set; }

    public string? NoiDung { get; set; }

    public DateOnly? NgayDang { get; set; }

    public string? TacGia { get; set; }
}
