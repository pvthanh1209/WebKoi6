using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.BLL.InterfaceBLL;
using WebKoi6.DAL;
using WebKoi6.DAL.Implement;
using WebKoi6.DAL.Interface;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.ImplementBLL
{
    public class IplBacsiBLL : IBacsiBLL
    {
        private readonly IBaseDAL _baseDAL;
        public IplBacsiBLL(IBaseDAL baseDAL)
        {
            _baseDAL = baseDAL;
        }

        public List<Bacsi> GetAll()
        {
            return _baseDAL.bacsiRepository.GetAll();
        }

        public List<Bacsi> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10)
        {
            return _baseDAL.bacsiRepository.GetListAllPaging(keywork, offset, limit);
        }
    }
}
