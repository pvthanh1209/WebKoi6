using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Implement;
using WebKoi6.DAL.Interface;
using WebKoi6.DAL.Models;

namespace WebKoi6.DAL
{
    public class IplBaseDAL : IBaseDAL
    {
        private KvscContext _dbContext;
        public IConfiguration _configuration { get; }
        public IplBaseDAL(KvscContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }
        private IBacsiRepository _bacsiRepository;
        public IBacsiRepository bacsiRepository
        {
            get
            {
                return _bacsiRepository ?? (_bacsiRepository = new BacsiRepository(_dbContext, _configuration));
            }
        }
        private ITaikhoanRepository _taikhoanRepository;
        public ITaikhoanRepository taikhoanRepository
        {
            get
            {
                return _taikhoanRepository ?? (_taikhoanRepository = new TaikhoanRepository(_dbContext, _configuration));
            }
        }
        private IDichvuthuy _dichvuthuyRepository;
        public IDichvuthuy dichvuthuyRepository
        {
            get
            {
                return _dichvuthuyRepository ?? (_dichvuthuyRepository = new DichvuthuyRepository(_dbContext, _configuration));
            }
        }
        private IKhachhang _khachhangRepository;
        public IKhachhang khachhangRepository
        {
            get
            {
                return _khachhangRepository ?? (_khachhangRepository = new KhachhangRepository(_dbContext, _configuration));
            }
        }
        private IFeebackRepository _feebackRepository;
        public IFeebackRepository feebackRepository
        {
            get
            {
                return _feebackRepository ?? (_feebackRepository = new FeebackRepository(_dbContext, _configuration));
            }
        }
        private IBanggiaRepository _banggiaRepository;
        public IBanggiaRepository banggiaRepository
        {
            get
            {
                return _banggiaRepository ?? (_banggiaRepository = new BanggiaRepository(_dbContext, _configuration));
            }
        }
    }
}
