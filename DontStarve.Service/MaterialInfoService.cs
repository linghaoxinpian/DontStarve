using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontStarve.Model;
using DontStarve.IService;

namespace DontStarve.Service
{
    public class MaterialInfoService : BaseService<materialinfo>, IMaterialInfoService
    {
        public materialinfo AddEntityAndReturn(materialinfo entity)
        {
            int id= dbSessioin.imaterialInfoDAL.InsertAddReturnId(entity);
            return LoadEntities(m => m.auto_id == id).FirstOrDefault();
        }
        protected override void Set_CurrentDAL()
        {
            CurrentDAL = dbSessioin.imaterialInfoDAL;
        }
    }
}
