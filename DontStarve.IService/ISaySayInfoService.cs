using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontStarve.Model;

namespace DontStarve.IService
{
    public interface ISaySayInfoService : IBaseService<saysayinfo>
    {
        /// <summary>
        /// 加载所有公开说说
        /// </summary>
        /// <returns></returns>
        dynamic LoadWorldFriend(int pageIndex, int pageSize, out int count);

        /// <summary>
        /// 仅加载我的好友的说说
        /// </summary>
        /// <param name="myFriend_pageIndex"></param>
        /// <param name="myFriend_pageSize"></param>
        /// <param name="myFriend_count"></param>
        /// <returns></returns>
        dynamic LoadMyFriend(Guid current_user, int myFriend_pageIndex, int myFriend_pageSize, out int myFriend_count);
    }
}
