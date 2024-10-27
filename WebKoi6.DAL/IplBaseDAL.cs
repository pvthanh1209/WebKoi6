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
    }
}
