using SqlSugar;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW.Host.API.Model.ModelEntity
{
    /// <summary>
    /// 背景图片信息
    /// </summary>
    public class HW_BackGroundImageInfo : Entity
    {
        // id Url
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 背景图片URL
        /// </summary>
        public string BGUrl { get; set; }
    }
}