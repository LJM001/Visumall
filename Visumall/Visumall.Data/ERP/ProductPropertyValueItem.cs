using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visumall.Data.ERP
{

    /// <summary>
    /// 产品属性组别事项勾选
    /// </summary>
    public class ProductPropertyValueItem
    {

        /// <summary>
        /// 表ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 产品标识
        /// </summary>
        public string ProductGuid { get; set; }

        /// <summary>
        /// 产品属性选项值
        /// </summary>
        public string PropertyGroupItemGuid { get; set; }

        /// <summary>
        /// 产品属性值
        /// </summary>
        public ProductPropertyGroupItem ProductPropertyGroupItem { get; set; }

        /// <summary>
        /// 产品
        /// </summary>
        public Product Product { get; set; }
    }


}
