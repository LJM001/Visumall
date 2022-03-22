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
    /// 产品图片库
    /// 注:主要存储一个产品的多张图片
    /// </summary>
    [SugarTable("ProductFiles")]
    public class ProductFile
    {

        /// <summary>
        /// 自增列ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 产品标识
        /// </summary>
        [StringLength(100)]
        public string ProductGuid { get; set; }

        /// <summary>
        /// 文件对于产品的类型
        /// Banner图
        /// 详情图
        /// 首页图
        /// 其他.....
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 图片路径
        /// </summary>
        [MaxLength(500)]
        public string Path { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        [MaxLength(250)]
        public string FileName { get; set; }

        /// <summary>
        /// 文件类型
        /// .mp4
        /// .jpg
        /// .png
        /// </summary>
        [MaxLength(50)]
        public string FileType { get; set; }

        /// <summary>
        /// 文件用处标题
        /// 主要这个图片或者视频的一个标题
        /// </summary>
        [MaxLength(100)]
        public string Title { get; set; }

        /// <summary>
        /// 描述
        /// 陈述该文件对于该产品的作用是什么
        /// 比如说:banner轮播图\详情图
        /// </summary>
        [MaxLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// 上传时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// 产品对象
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public CompanyProduct Product { get; set; }

    }
}
