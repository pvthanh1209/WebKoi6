using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Interface;

namespace WebKoi6.DAL
{
    public interface IBaseDAL
    {
        IBacsiRepository bacsiRepository { get; }
        ITaikhoanRepository taikhoanRepository { get; }
        IDichvuthuy dichvuthuyRepository { get; }
        IKhachhang khachhangRepository { get; }
        IFeebackRepository feebackRepository { get; }
        IBanggiaRepository banggiaRepository { get; }
    }
}
