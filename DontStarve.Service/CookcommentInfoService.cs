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

            return CurrentDAL.LoadEntities(cm => cm.CookId == guid_id).OrderBy(cm=>cm.PraiseNum).ToList();
        
        }

        protected override void Set_CurrentDAL()
        {
            CurrentDAL= dbSessioin.icookcommentInfoDAL;
        }
    }
}
