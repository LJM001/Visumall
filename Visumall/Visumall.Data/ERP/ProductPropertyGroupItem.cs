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
    /// 组别属性表
    /// </summary>
    [SugarTable("ProductPropertyGroupItems")]
    public class ProductPropertyGroupItem
    {

        /// <summary>
        /// 属性表自增列Id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 属性组别表的标识ID
        /// </summary>
        [MaxLength(100)]
        public string PropertyGroupId { get; set; }

        /// <summary>
        /// 属性标题
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 所属的产品属性组别
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public ProductPropertyGroup ProductPropertyGroup { get; set; }

    }


}
