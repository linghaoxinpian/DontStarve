using DontStarve.IService;
using DontStarve.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.Service
{
    public class CookieInfoService : BaseService<cookinfo>, ICookieInfoService
    {
        public void AddPraise(Guid guid_id)
        {
            var entity = LoadEntities(c => c.Guid_id == guid_id).FirstOrDefault();
            entity.PraiseNum++;
            entity.Rating = (byte?)(entity.PraiseNum / 50);
            EditEntity(entity);
        }

        public cookinfo LoadEntitByCookieId(Guid cookie_guid)
        {
            return CurrentDAL.LoadEntities(c => c.Guid_id == cookie_guid).FirstOrDefault();
        }

        public Dictionary<Guid, string> LoadEntitiesByCategoryId(int category_id)
        {
            return dbSessioin.icookieInfoDAL.LoadEntitiesByCategoryId(category_id).ToDictionary(c => c.Guid_id, c => c.Name);
        }

        public List<cookinfo> LoadHotCookieByWeek(int count = 10)
        {
           
        }

        protected override void Set_CurrentDAL()
        {
            CurrentDAL = dbSessioin.icookieInfoDAL;
        }
    }
}
