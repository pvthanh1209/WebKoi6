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
                int totalRow = dbBacsi.Count();
                var data = (from b in dbBacsi
                           where((string.IsNullOrEmpty(keywork) 
                           || b.TenBacSi.ToLower().Trim().Contains(keywork.ToLower().Trim())))
                           select new Bacsi
                           {
                                Id = b.Id,
                                TenBacSi = b.TenBacSi,
                                KinhNghiem = b.KinhNghiem,
                                Email = b.Email,
                                Availability = b.Availability,
                                TotalRows = totalRow,
                           }).Skip(offset).Take(limit).ToList();
                return data;            
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
