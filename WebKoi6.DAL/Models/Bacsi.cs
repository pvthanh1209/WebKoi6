using System;
using System.Collections.Generic;

namespace WebKoi6.DAL.Models;

public partial class Bacsi
{
    public int Id { get; set; }
    public string? TenBacSi { get; set; }

    public int KinhNghiem { get; set; }

    public string? Email { get; set; }

    public string? Availability { get; set; }
}
