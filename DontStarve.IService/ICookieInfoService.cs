using DontStarve.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.IService
{
    public interface ICookieInfoService : IBaseService<cookinfo>
    {
        /// <summary>
        /// 根据"分类id“加载Cookie
        /// </summary>
        /// <param name="category_id">分类id</param>
        /// <returns></returns>
        Dictionary<Guid, string> LoadEntitiesByCategoryId(int cagegory_id);

        /// <summary>
        /// 根据“美食Id”查询该“美食”全部信息
        /// </summary>
        /// <param name="cookie_guid"></param>        
        cookinfo LoadEntitByCookieId(Guid cookie_guid);
    }
}
