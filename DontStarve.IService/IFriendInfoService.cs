using DontStarve.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.IService
{
    public interface IFriendInfoService : IBaseService<friendinfo>
    {
        List<userinfo> LoadFriend(Guid currentUser_guid);
    }
}
