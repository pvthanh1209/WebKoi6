using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebKoi6.DAL.Models
{
    public partial class Donthuoc
    {
        public int Id { get; set; }
        public int LichhenId { get; set; }  
        public string? Mota { get; set; }
    }
}
