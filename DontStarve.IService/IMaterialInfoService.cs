using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontStarve.Model;

namespace DontStarve.IService
{
    public interface IMaterialInfoService:IBaseService<materialinfo>
    {
        /// <summary>
        /// 插入并返回
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        materialinfo AddEntityAndReturn(materialinfo entity);
    }
}
