using SqlSugar;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW.Host.API.Model.ModelEntity
{
    /// <summary>
    /// 文案信息类
    /// </summary>
    public class HW_CopywritingInfo : Entity
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 文案内容
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string Content { get; set; }
    }
}