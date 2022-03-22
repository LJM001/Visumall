using System;
using System.ComponentModel.DataAnnotations;
using SqlSugar;

namespace Visumall.Data.ERP
{

    /// <summary>
    /// 账户角色关系表
    /// </summary>
    [SugarTable("AccountRoleRelations")]
    public class AccountRoleRelation
    {
        /// <summary>
        /// 自增列
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 账户标识ID
        /// </summary>
        [MaxLength(50)]
        public string AccountGuid { get; set; }

        /// <summary>
        /// 角色表ID
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// 是否有时效性
        /// </summary>
        public DateTime? ActiveTime { get; set; }

    }
}
