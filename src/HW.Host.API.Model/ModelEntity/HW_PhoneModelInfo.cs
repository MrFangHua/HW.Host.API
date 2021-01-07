using SqlSugar;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW.Host.API.Model.ModelEntity
{
    /// <summary>
    /// 手机型号详情
    /// </summary>
    public class HW_PhoneModelInfo : Entity
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
        /// 手机型号
        /// </summary>
        [Required]
        public string PhoneName { get; set; }

        /// <summary>
        /// 手机内存
        /// </summary>
        [Required]
        public string PhoneRAM { get; set; }

        /// <summary>
        /// 手机价格
        /// </summary>
        [Required]
        public int PhonePrice { get; set; }

        /// <summary>
        /// 手机成色
        /// </summary>
        [Required]
        public string PhoneFineness { get; set; }

        /// <summary>
        /// 手机颜色
        /// </summary>
        [Required]
        public string PhoneColour { get; set; }

        /// <summary>
        /// 手机串码
        /// </summary>
        [Required]
        public string PhoneCode { get; set; }

        /// <summary>
        /// 租凭时间
        /// </summary>
        [Required]
        public DateTime PhoneLeaseTime { get; set; }

        /// <summary>
        /// 是否归还（租赁归还）
        /// </summary>
        [Required]
        public int PhoneIsReturn { get; set; } = 0;

        /// <summary>
        /// 归还时间（租赁归还）
        /// </summary>
        public DateTime PhoneReturnTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string PhoneRemarks { get; set; }

        /// <summary>
        /// 手机归还备注
        /// </summary>
        public string PhoneReturnRemarks { get; set; }
    }
}