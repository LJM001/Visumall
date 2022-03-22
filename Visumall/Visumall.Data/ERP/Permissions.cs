using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visumall.CommonBase.Enum;

namespace Visumall.Data.ERP
{

    /// <summary>
    /// 角色功能权限表
    /// </summary>
    [SugarTable("Permissions")]
    public class Permissions
    {

        /// <summary>
        /// 自增列
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// 功能ID
        /// </summary>
        public int FunctionId { get; set; }

        /// <summary>
        /// 权限
        /// </summary>
        public Permission Permission { get; set; }
    }


}
