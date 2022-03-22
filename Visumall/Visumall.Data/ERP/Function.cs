using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visumall.Data.ERP
{

    /// <summary>
    /// 功能表
    /// </summary>
    [SugarTable("Permissions")]
    public class Function
    {

        /// <summary>
        /// 功能表自增列
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 菜单ID
        /// </summary>
        public int MenuId { get; set; }

        /// <summary>
        /// 功能名称
        /// </summary>
        [MaxLength(100)]
        public string FunctionName { get; set; }

        /// <summary>
        /// 功能视图页面的URL
        /// </summary>
        public string FunctionViewUrl { get; set; }
    }


}
