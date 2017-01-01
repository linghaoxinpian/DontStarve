using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontStarve.Model;

namespace DontStarve.IDAL
{
    public interface IMaterialInfoDAL : IBaseDAL<materialinfo>
    {
        /// <summary>
        /// 插入并返回自增列的值
        /// </summary>
        /// <returns></returns>
        int InsertAddReturnId(materialinfo entity);
    }
}
