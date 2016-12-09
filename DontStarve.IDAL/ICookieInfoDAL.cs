using DontStarve.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.IDAL
{
    public interface ICookieInfoDAL:IBaseDAL<cookinfo>
    {
        /// <summary>
        /// 根据”分类Id“查找出所有”美食“集合
        /// </summary>
        /// <param name="category_id"></param>
        /// <returns></returns>
        ICollection<cookinfo> LoadEntitiesByCategoryId(int category_id);
    }
}
