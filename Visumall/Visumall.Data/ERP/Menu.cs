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
    /// 菜单表
    /// </summary>
    [SugarTable("Menus")]
    public class Menu
    {

        /// <summary>
        /// 菜单表自增列
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        [MaxLength(100)]
        public string MenuName { get; set; }

        /// <summary>
        /// 菜单的Icon图标
        /// </summary>
        [MaxLength(300)]
        public string Icon { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [MaxLength(500)]
        public string Remark { get; set; }

        /// <summary>
        /// 菜单下的功能集合
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public List<Function> FunctionItems { get; set; }

    }



}
