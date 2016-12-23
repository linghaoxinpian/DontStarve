using DontStarve.IService;
using DontStarve.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontStarve.Common;

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

        public List<cookinfo> LoadHotCookieByWeek(int size = 10)
        {
            //获取一周内的时间戳范围
            long curentStamp=CommonHelper.GetCurrentDateStamp();    //当前时间戳
            long weekLast = CommonHelper.GetCurrentDateStamp(DateTime.Now.AddDays(-7)); //后退七天的时间戳
            int totalCount;
            var list= LoadPageEntities(c => c.DelFlag == false,c=>c.PraiseNum,1,size,out totalCount,false);
            return list.ToList();
        }

        protected override void Set_CurrentDAL()
        {
            CurrentDAL = dbSessioin.icookieInfoDAL;
        }
    }
}
