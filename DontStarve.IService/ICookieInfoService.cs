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
        /// 根据Name查询
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
         List<cookinfo> LoadCookByCookName(string name);

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
        
        /// <summary>
        /// 点赞数加一
        /// </summary>
        void AddPraise(Guid guid_id);

        /// <summary>
        /// 返回周最热
        /// </summary>
        /// <param name="count">返回几条数据</param>
        /// <returns></returns>
        List<cookinfo> LoadHotCookieByWeek(int count=10);
    }
}
