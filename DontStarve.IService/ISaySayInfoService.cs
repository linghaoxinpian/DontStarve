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
    }
}
