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

        /// <summary>
        /// 根据美食id加载最火的评论
        /// </summary>
        /// <param name="cookies"></param>
        /// <returns></returns>
        List<cookcommentinfo> LoadHotCookieCommentByCoookieIds(params Guid[] cookies);
        List<cookcommentinfo> LoadHotCommentByCookieId(Guid id, int size);
    }
}
