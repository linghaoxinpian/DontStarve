using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontStarve.Model;

namespace DontStarve.IService
{
    public interface ISaysaycommentInfoService : IBaseService<saysaycommentinfo>
    {
       void LoadReplyBySaysayId(Guid saySayId, int v1, int v2, out int count);
    }
}
