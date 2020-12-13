using HW.Host.API.Model.DefaultEntity;
using SqlSugar;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW.Host.API.Model.ModelEntity
{
    /// <summary>
    /// 报餐详情
    /// </summary>
    public class HW_ReportMealInfo : Entity
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
        /// 报餐员工ID
        /// </summary>
        [Required]
        public int ReportMealUserID { get; set; }

        /// <summary>
        /// 用户表关联
        /// </summary>
        [ForeignKey("ReportMealUserID")]
        [SugarColumn(IsIgnore = true)]
        public HW_Users HW_Users { get; set; }

        /// <summary>
        /// 报餐时间（年-月-日/1900-1-1）不带0的日期时间
        /// </summary>
        [Required]
        public string ReportMealTime { get; set; }

        /// <summary>
        /// 中餐
        /// </summary>
        [Required]
        public int Lunch { get; set; } = 0;

        /// <summary>
        /// 晚餐
        /// </summary>
        [Required]
        public int Dinner { get; set; } = 0;
    }
}