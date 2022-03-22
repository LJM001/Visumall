﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visumall.Data.ERP
{

    /// <summary>
    /// 产品实体
    /// </summary>
    public class Product
    {
        /// <summary>
        /// 自增列ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 产品唯一标识
        /// </summary>
        [StringLength(100)]
        public string Guid { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        [MaxLength(100)]
        public string ProductSN { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string ProductName { get; set; }

        /// <summary>
        /// 商品类型Id
        /// </summary>
        [StringLength(100)]
        public string ProductTypeGuid { get; set; }

        /// <summary>
        /// 属性组别Guid标识
        /// </summary>
        [StringLength(100)]
        public string PropertyGroupGuid { get; set; }

        /// <summary>
        /// 官方价
        /// </summary>
        public decimal OfficialPrice { get; set; }
        
        /// <summary>
        /// 产品单价
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 状态
        /// 1:上架
        /// 2:下架
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 上架\下架
        /// 时间
        /// </summary>
        public DateTime? StatusTime { get; set; }

        /// <summary>
        /// 是否有效
        /// 0: 已删
        /// 1: 有效
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [MaxLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// 产品分类
        /// </summary>
        public ProductType ProductType { get; set; }

        /// <summary>
        /// 产品属性组别
        /// </summary>
        public ProductPropertyGroup PropertyGroup { get; set; }

        /// <summary>
        /// 产品文件集合
        /// </summary>
        public List<ProductFile> ProductFileItems { get; set; }

    }
}
