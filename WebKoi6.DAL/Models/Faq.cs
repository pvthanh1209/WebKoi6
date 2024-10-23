using System;
using System.Collections.Generic;

namespace WebKoi6.DAL.Models;

public partial class Faq
{
    public int Faqid { get; set; }

    public string? CauHoi { get; set; }

    public string? CauTraLoi { get; set; }
}
