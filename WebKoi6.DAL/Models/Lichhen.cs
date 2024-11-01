using System;
using System.Collections.Generic;

namespace WebKoi6.DAL.Models;

public partial class Lichhen
{
    public int Id { get; set; }
    public int KhachhangId { get; set; }
    public int BacsiId { get; set; }
    public int DichVuId { get; set; }
    public DateTime? Ngayhen { get; set; }
    public int Trangthai { get; set; }
}
