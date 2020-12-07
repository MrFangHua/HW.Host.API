using SqlSugar;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW.Host.API.Model.ModelEntity
{
    /// <summary>
    /// 邮件历史信息
    /// </summary>
    public class HW_EmailHistoryInfo : Entity
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
        /// 收件人账号
        /// </summary>
        [Required]
        public string RecipientId { get; set; }

        /// <summary>
        /// 邮件内容
        /// </summary>
        [Required]
        public string EmailBody { get; set; }

        /// <summary>
        /// 邮件验证码
        /// </summary>
        public string EmailCode { get; set; } = null;
    }
}