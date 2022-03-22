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
    /// 属性组别表
    /// </summary>
    public class ProductPropertyGroup
    {

        /// <summary>
        /// 属性Id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 属性组的标识
        /// </summary>
        [MaxLength(100)]
        public string Guid { get; set; }

        /// <summary>
        /// 产品属性名称 -- 对应中文
        /// </summary>
        public string PropertyGroupName { get; set; }

        /// <summary>
        /// 属性组别排序
        /// </summary>
        public int Sort { get; set; }
        
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 产品属性组别 的选项集合
        /// </summary>
        public List<ProductPropertyGroupItem> ProductPropertyGroupItems { get; set; }

    }


}
