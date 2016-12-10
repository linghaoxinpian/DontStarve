using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontStarve.Model;
using DontStarve.Model.ViewModel;

namespace DontStarve.IService
{
    public interface ICookcommentInfoService : IBaseService<cookcommentinfo>
    {
        List<cookcommentinfo> LoadEntitiesByCookieId(Guid guid_id);
    }
}
