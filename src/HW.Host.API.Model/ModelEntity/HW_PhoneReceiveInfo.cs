using HW.Host.API.Model.DefaultEntity;
using SqlSugar;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW.Host.API.Model.ModelEntity
{
    /// <summary>
    /// 手机领取详情
    /// </summary>
    public class HW_PhoneReceiveInfo : Entity
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
        /// 领取时间
        /// </summary>
        [Required]
        public DateTime ReceiveTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 领取员工ID
        /// </summary>
        [Required]
        public int ReceiveUserID { get; set; }

        /// <summary>
        /// 用户表关联
        /// </summary>
        [ForeignKey("ReceiveUserID")]
        public HW_Users HW_Users { get; set; }

        /// <summary>
        /// 领取型号详情ID
        /// </summary>
        [Required]
        public int ReceivePhoneModelID { get; set; }

        /// <summary>
        /// 手机型号
        /// </summary>
        [ForeignKey("ReceivePhoneModelID")]
        public HW_PhoneModelInfo HW_PhoneModelInfo { get; set; }

        /// <summary>
        /// 是否归还
        /// </summary>
        [Required]
        public int ReceiveIsReturn { get; set; } = 0;

        /// <summary>
        /// 归还时间
        /// </summary>
        public DateTime ReceiveReturnTime { get; set; }

        /// <summary>
        /// 领取备注
        /// </summary>
        public string ReceiveRemarks { get; set; }

        /// <summary>
        /// 归还备注
        /// </summary>
        public string ReturnRemarks { get; set; }
    }
}