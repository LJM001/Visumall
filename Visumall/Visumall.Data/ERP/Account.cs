using SqlSugar;
using System; 
using System.ComponentModel.DataAnnotations;
 

namespace Visumall.Data.ERP
{

    /// <summary>
    /// 账号表
    /// </summary>
    [SugarTable("Accounts")]
    public class Account
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
        /// 登录账号
        /// </summary>
        [MaxLength(50)]
        public string LoginAccount { get; set; }

        /// <summary>
        /// 电话(同样可以作为登录账号)
        /// </summary>
        [MaxLength(20)]
        public string Phone { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        [MaxLength(50)]
        public string Password { get; set; }

        /// <summary>
        /// 账号状态
        /// 1:正常
        /// 2:冻结
        /// 3:失效
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 微信OpenId
        /// </summary>
        [MaxLength(200)]
        public string WeiXinOpenId { get; set; }

        /// <summary>
        /// 微信UnionId
        /// </summary>
        [MaxLength(200)]
        public string WeiXinUnionId { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime LastLoginTime { get; set; }

        /// <summary>
        /// Ip地址
        /// </summary>
        [MaxLength(50)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 最后修改
        /// </summary>
        public DateTime LastUpdateTime { get; set; }


    }
}
