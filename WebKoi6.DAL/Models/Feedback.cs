using System;
using System.Collections.Generic;

namespace WebKoi6.DAL.Models;

public partial class Feedback
{
    public int FeedbackId { get; set; }

    public string? TenKhachHang { get; set; }

    public string? Email { get; set; }

    public string? DanhGia { get; set; }

    public string? BinhLuan { get; set; }

    public DateOnly? NgayPhanHoi { get; set; }
}
