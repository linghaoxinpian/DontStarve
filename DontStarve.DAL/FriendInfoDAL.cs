using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontStarve.Model;
using DontStarve.IDAL;

namespace DontStarve.DAL
{
    public class FriendInfoDAL:BaseDAL<friendinfo>, IFriendInfoDAL
    {
        public List<userinfo> LoadFriend(Guid currentUser_guid)
        {
            return null;
        }
    }
}
