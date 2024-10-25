using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Interface;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.ImplementBLL
{
    public class IplBacsiBLL : IBacsiRepository
    {
        private readonly IBacsiRepository _bacsiRepository;
        public IplBacsiBLL(IBacsiRepository bacsiRepository)
        {
            _bacsiRepository = bacsiRepository;
        }

        public List<Bacsi> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10)
        {
            return _bacsiRepository.GetListAllPaging(keywork, offset, limit);
        }
    }
}
