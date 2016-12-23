using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontStarve.Model;
using DontStarve.IService;
using DontStarve.Model.ViewModel;

namespace DontStarve.Service
{
    public class CookcommentInfoService : BaseService<cookcommentinfo>, ICookcommentInfoService
    {
        public List<cookcommentinfo> LoadEntitiesByCookieId(Guid guid_id)
        {

            return CurrentDAL.LoadEntities(cm => cm.CookId == guid_id).OrderBy(cm => cm.PraiseNum).ToList();

        }

        public List<cookcommentinfo> LoadHotCommentByCookieId(Guid id, int size)
        {
            var list = LoadEntities(sc => sc.CookId == id).OrderBy(sc => sc.PraiseNum).Take(size).ToList();
            return list;
        }

        public List<cookcommentinfo> LoadHotCookieCommentByCoookieIds(params Guid[] cookies)
        {
            //var allComment = LoadEntities(sc => true);
            //var list = from sc in allComment
            //            from id in cookies
            //            where sc.CookId == id
            //            orderby sc.PraiseNum
            //            select sc;
            //list=list.Take(cookies)
            //return list;
            return null;
        }

        protected override void Set_CurrentDAL()
        {
            CurrentDAL = dbSessioin.icookcommentInfoDAL;
        }
      
    }
}
