using DontStarve.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.IService
{
    public interface IUserInfoService : IBaseService<userinfo>
    {
        userinfo Login(string username, string userpwd);
    }
}
