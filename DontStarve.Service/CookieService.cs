using DontStarve.IService;
using DontStarve.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.Service
{
    public class CookieService : BaseService<cookinfo>, ICookieInfoService
    {
        protected override void Set_CurrentDAL()
        {
            CurrentDAL = dbSessioin.icookieInfoDAL;
        }
    }
}
