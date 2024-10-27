using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.BLL.InterfaceBLL;

namespace WebKoi6.BLL
{
    public interface IBaseBLL
    {
        IBacsiBLL bacsiBLLRepo { get; }
        ITaiKhoanBLL taiKhoanBLL { get; }
    }
}
