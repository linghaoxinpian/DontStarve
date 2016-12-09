using DontStarve.IDAL;
using DontStarve.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.DAL
{
    public class CookieInfoDAL : BaseDAL<cookinfo>, ICookieInfoDAL
    {
        public ICollection<cookinfo> LoadEntitiesByCategoryId(int category_id)
        {
            var cates = dbContext.Set<categoryinfo>().Where(cate => cate.Auto_id == category_id).FirstOrDefault().cookinfo;
            return cates;
        }
    }
}
