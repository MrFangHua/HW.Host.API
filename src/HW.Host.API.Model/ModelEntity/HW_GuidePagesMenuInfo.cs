using SqlSugar;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW.Host.API.Model.ModelEntity
{
    /// <summary>
    /// 引导页菜单信息
    /// </summary>
    public class HW_GuidePagesMenuInfo : Entity
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        [Required]
        public string MenuName { get; set; }

        /// <summary>
        /// 菜单Url
        /// </summary>
        [Required]
        public string MenuUrl { get; set; }

        /// <summary>
        /// 父级菜单Id
        /// </summary>
        [Required]
        public int ParentId { get; set; } = 0;

        /// <summary>
        /// 菜单排序
        /// </summary>
        [Required]
        public int MenuOrder { get; set; } = 1;
    }
}