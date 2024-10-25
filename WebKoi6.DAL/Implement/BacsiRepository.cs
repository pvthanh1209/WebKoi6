using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Interface;
using WebKoi6.DAL.Models;

namespace WebKoi6.DAL.Implement
{
    public class BacsiRepository : IBacsiRepository
    {
        private readonly KvscContext _context;
        public BacsiRepository(KvscContext context)
        {
            _context = context;
        }

        public List<Bacsi> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10)
        {
            try
            {
                var dbBacsi = _context.Bacsis.AsQueryable();
                
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
