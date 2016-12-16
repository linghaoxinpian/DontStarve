using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontStarve.IService;
using DontStarve.Model;

namespace DontStarve.Service
{
    public class SaysaycommentInfoService : BaseService<saysaycommentinfo>, ISaysaycommentInfoService
    {
        public  LoadReplyBySaysayId(Guid saySayId, int pageIndex, int pageSize, out int count)
        {
            var isc = LoadPageEntities(sc => sc.SaysayId == saySayId, sc => sc.Subtime, pageIndex, pageSize, out count);
            var iu = dbSessioin.iuserInfoDAL.LoadEntities(u => u.DelFlag == false);
            var lvar = from i in isc
                       from u in iu
                       where i.UserId == u.Guid_id
                       select new
                       {
                           u.Guid_id,
                           u.Name
                       };
            return lvar;
        }

        protected override void Set_CurrentDAL()
        {
            CurrentDAL = dbSessioin.isaysaycommentInfoDAL;
        }
    }
}
