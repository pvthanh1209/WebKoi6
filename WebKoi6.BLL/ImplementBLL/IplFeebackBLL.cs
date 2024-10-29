using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.BLL.InterfaceBLL;
using WebKoi6.DAL;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.ImplementBLL
{
    public class IplFeebackBLL : IFeebackBLL
    {
        private readonly IBaseDAL _baseDAL;
        public IplFeebackBLL(IBaseDAL baseDAL)
        {
            _baseDAL = baseDAL;
        }

        public List<Feedback> GetFeedbackListAllPaging(string search, int offset, int limit)
        {
            return _baseDAL.feebackRepository.GetFeebackListAllPaging(search, offset, limit);
        }
    }
}
