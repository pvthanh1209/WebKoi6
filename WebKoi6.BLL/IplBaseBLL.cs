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
        private IDichvuthuyBLL _dichvuBLLRepo;
        public IDichvuthuyBLL dichvuthuyBLL
        {
            get
            {
                return _dichvuBLLRepo ?? (_dichvuBLLRepo = new IplDichvuthuyBLL(_baseDAL));
            }
        }
        private IKhachhangBLL _khachhangBLLRepo;
        public IKhachhangBLL khachhangBLL
        {
            get
            {
                return _khachhangBLLRepo ?? (_khachhangBLLRepo = new IplKhachhangBLL(_baseDAL));
            }
        }
        private IFeebackBLL _feebackBLLRepo;
        public IFeebackBLL feebackBLL
        {
            get
            {
                return _feebackBLLRepo ?? (_feebackBLLRepo = new IplFeebackBLL(_baseDAL));
            }
        }
        private IBanggiaBLL _banggiaBLLRepo;
        public IBanggiaBLL banggiaBLL
        {
            get
            {
                return _banggiaBLLRepo ?? (_banggiaBLLRepo = new IplBanggiaBLL(_baseDAL));
            }
        }
    }
}
