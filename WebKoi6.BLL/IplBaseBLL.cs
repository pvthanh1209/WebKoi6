using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.BLL.ImplementBLL;
using WebKoi6.BLL.InterfaceBLL;
using WebKoi6.DAL;
using WebKoi6.DAL.Implement;
using WebKoi6.DAL.Interface;

namespace WebKoi6.BLL
{
    public class IplBaseBLL : IBaseBLL
    {
        protected readonly IBaseDAL _baseDAL;
        public IplBaseBLL(IBaseDAL baseDAL)
        {
            _baseDAL = baseDAL;
        }
        private IBacsiBLL _bacsiBLLRepo;
        public IBacsiBLL bacsiBLLRepo
        {
            get
            {
                return _bacsiBLLRepo ?? (_bacsiBLLRepo = new IplBacsiBLL(_baseDAL));
            }
        }
        private ITaiKhoanBLL _taikhoanBLLRepo;
        public ITaiKhoanBLL taiKhoanBLL
        {
            get
            {
                return _taikhoanBLLRepo ?? (_taikhoanBLLRepo = new IplTaiKhoanBLL(_baseDAL));
            }
        }
    }
}
