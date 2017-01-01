using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontStarve.Model;
using DontStarve.IService;

namespace DontStarve.Service
{
    class LeavenoteInfoService : BaseService<leavenoteinfo>, ILeavenoteInfoService
    {
        protected override void Set_CurrentDAL()
        {
            CurrentDAL = dbSessioin.ileavenoteInfoDAL;
        }
    }
}
