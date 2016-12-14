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
                        select u.userinfo;
            return b.ToList();
            
        }

        protected override void Set_CurrentDAL()
        {
            CurrentDAL = dbSessioin.ifriendInfoDAL;
        }
    }
}
