using DontStarve.IService;
using DontStarve.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.Service
{
    public class CategoryInfoService : BaseService<categoryinfo>, ICategoryInfoService
    {
        public Dictionary<int, string> LoadCategoryByLevel1()
        {
            var temp = CurrentDAL.LoadEntities(e => e.Level == 1).ToDictionary(c => c.Auto_id,c => c.Name);
            return temp;               
        }

        protected override void Set_CurrentDAL()
        {
            CurrentDAL=dbSessioin.icategoryInfoDAL;
        }
    }
}
