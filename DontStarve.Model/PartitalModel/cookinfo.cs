using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DontStarve.Model.PartitalModel
{
    [MetadataType(typeof(Model.cookinfo))]
    public partial class cookinfo
    {
        /// <summary>
        /// 给管理员看的备注信息
        /// </summary>
        public string Remark { get; set; }
    }
}
