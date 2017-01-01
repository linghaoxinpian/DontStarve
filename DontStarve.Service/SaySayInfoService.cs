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
        public dynamic LoadMyFriend(Guid current_user, int myFriend_pageIndex, int myFriend_pageSize, out int myFriend_count)
        {
            var iq_friend = dbSessioin.ifriendInfoDAL.LoadEntities(f => f.UserId == current_user);
            var iq_user = dbSessioin.iuserInfoDAL.LoadEntities(u => u.DelFlag == false);
            //筛选出好友
            var ie_user = from f in iq_friend
                          from u in iq_user
                          where f.FriendId == u.Guid_id
                          select u;

            var iq_say = LoadEntities(s => s.DelFlag == false);
            //得到匿名集合
            var list = from u in ie_user
                       from s in iq_say
                       where u.Guid_id == s.UserId
                       select new
                       {
                         saysayId= s.Guid_id,
                           s.Pic,
                           u.Name,
                           s.PraiseNum,
                           s.Subtime,
                           s.Content,
                          userId= u.Guid_id,  // 该说说的发表者Id
                       };
            myFriend_count = list.Count();
            list = list.OrderBy(l => l.Subtime).Skip((myFriend_pageIndex - 1) * myFriend_pageSize).Take(myFriend_pageSize);
            return list;
        }
        public dynamic LoadWorldFriend(int pageIndex, int pageSize, out int count)
        {
            var iq_saysay = LoadPageEntities(s => s.DelFlag == false && s.IsAllUserCanSee == true, s => s.PraiseNum, pageIndex, pageSize, out count, false);
            var iq_user = dbSessioin.iuserInfoDAL.LoadEntities(u => u.DelFlag == false);
            //匿名集合
            var list = from s in iq_saysay
                       from u in iq_user
                       where s.UserId == u.Guid_id
                       select new
                       {
                           s.Pic,
                           u.Name,
                           s.PraiseNum,
                           s.Subtime,
                           s.Content,
                           s.Guid_id
                       };
            return list;
        }

        protected override void Set_CurrentDAL()
        {
            CurrentDAL = dbSessioin.isaysayInfoDAL;
        }
    }
}
