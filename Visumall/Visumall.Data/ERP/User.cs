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
    /// ERP系统的用户信息
    /// </summary>
    [SugarTable("Users")]
    public class User
    {

        /// <summary>
        /// 自增列ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 唯一标识
        /// </summary>
        [MaxLength(100)]
        public string Guid { get; set; }

        /// <summary>
        /// 会员姓名
        /// </summary>

        [MaxLength(50)]
        public string UserName { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        /// <summary>
        /// 出生
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public bool Gender { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        [MaxLength(100)]
        public string CompanyId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [MaxLength(100)]
        public string ShopId { get; set; }

        /// <summary>
        /// 账号表的外键
        /// </summary>
        [MaxLength(100)]
        public string AccountGuid { get; set; }

        /// <summary>
        /// 省份ID
        /// </summary>
        public int ProvinceId { get; set; }

        /// <summary>
        /// 省份ID
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [MaxLength(255)]
        public string Address { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// 导航属性  Account <1--1> User
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public Account Account { get; set; }
    }


}
