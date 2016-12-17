using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontStarve.IService;
using DontStarve.Model;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DontStarve.App")]
namespace DontStarve.Service
{
    public class SaysaycommentInfoService : BaseService<saysaycommentinfo>, ISaysaycommentInfoService
    {
        /// <summary>
        /// 加载说说回复
        /// </summary>
        /// <param name="saySayId"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public dynamic LoadReplyBySaysayId(Guid saySayId, int pageIndex, int pageSize, out int count)
        {
            var isc = LoadPageEntities(sc => sc.SaysayId == saySayId, sc => sc.Subtime, pageIndex, pageSize, out count);
            var iu = dbSessioin.iuserInfoDAL.LoadEntities(u => u.DelFlag == false);
            var lvar = from i in isc
                       from u in iu
                       from tu in iu
                       where i.UserId == u.Guid_id
                       where i.ToUserId == tu.Guid_id
                       select new
                       {
                           u.Guid_id,   //回复者的id
                           u.Name,  //回复者的Name
                           ToName = tu.Name, //被回复者的Name
                           i.Content,   //回复内容
                           i.Subtime    //回复时间
                       };
            return lvar;
        }

        protected override void Set_CurrentDAL()
        {
            CurrentDAL = dbSessioin.isaysaycommentInfoDAL;
        }
    }
}
