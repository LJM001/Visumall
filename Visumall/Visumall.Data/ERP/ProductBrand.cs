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
    /// 品牌表
    /// </summary>
    [SugarTable("ProductBrands")]
    public class ProductBrand
    {

        /// <summary>
        /// 品牌ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 品牌唯一标识
        /// </summary>
        [StringLength(100)]
        public string Guid { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [MaxLength(50)]
        public string BrandName { get; set; }

        /// <summary>
        /// 品牌描述
        /// </summary>
        [MaxLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// 品牌排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 产品集合
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public List<CompanyProduct> ProductItems { get; set; }


    }
}
