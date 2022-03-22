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
    /// 商品类型
    /// </summary>
    [SugarTable("ProductTypes")]
    public class ProductType
    {

        /// <summary>
        /// 商品类型ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 分类标识
        /// </summary>
        [StringLength(100)]
        public string Guid { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        [MaxLength(50)]
        public string TypeName { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 类型状态
        /// 0:失效
        /// 1:有效
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 产品集合
        /// ProductType <1-->N>
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public List<CompanyProduct> ProductItems { get; set; }

    }
}
