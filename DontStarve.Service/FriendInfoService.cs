using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontStarve.Model;
using DontStarve.IService;

namespace DontStarve.Service
{
    public class FriendInfoService : BaseService<friendinfo>, IFriendInfoService
    {
        public List<userinfo> LoadFriend(Guid currentUser_guid)
        {
            var a = LoadEntities(f => f.UserId == currentUser_guid);
            var  b= from u in a
                        select u.FriendId;
            var c = dbSessioin.iuserInfoDAL.LoadEntities(u => u.DelFlag == false);
            var d = from u in c
                    from b0 in b
                    where u.Guid_id==b0
                    select u;
            return d.ToList();
        }

        protected override void Set_CurrentDAL()
        {
            CurrentDAL = dbSessioin.ifriendInfoDAL;
        }
    }
}
