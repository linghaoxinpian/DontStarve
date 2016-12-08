using DontStarve.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.IService
{
    public interface ICategoryInfoService : IBaseService<categoryinfo>
    {
        /// <summary>
        /// 分页加载一级分类的美食分类
        /// </summary>        
        /// <returns></returns>
        Dictionary<int,string> LoadCategoryByLevel1();
    }
}
