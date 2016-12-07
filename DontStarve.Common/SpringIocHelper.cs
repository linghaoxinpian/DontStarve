using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.Common
{
    public class SpringIocHelper
    {
        private static Spring.Context.IApplicationContext ctx = Spring.Context.Support.ContextRegistry.GetContext();
        /// <summary>
        /// Ioc控制反转
        /// </summary>
        /// <param name="class_name"></param>
        /// <returns></returns>
        public static object GetObject(string class_name)
        {
            return ctx.GetObject(class_name);
        }
    }
}
