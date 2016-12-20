using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontStarve.Model;
using DontStarve.IService;

namespace DontStarve.Service
{
    public class SaySayInfoService : BaseService<saysayinfo>, ISaySayInfoService
    {
        public dynamic LoadWorldFriend(int pageIndex, int pageSize, out int count)
        {
            var iq_saysay = LoadPageEntities(s => s.DelFlag == false && s.IsAllUserCanSee == true, s => s.Subtime, pageIndex, pageSize, out count);
            var iq_user = dbSessioin.iuserInfoDAL.LoadEntities(u => u.DelFlag == false);

            var list = from s in iq_saysay
                       from u in iq_user
                       where s.UserId == u.Guid_id
                       select new
                       {
                           s.Pic,
                           u.Name,
                           s.PraiseNum,
                           s.Subtime,
                           s.Content
                       };
            return list;
        }

        protected override void Set_CurrentDAL()
        {
            CurrentDAL = dbSessioin.isaysayInfoDAL;
        }
    }
}
