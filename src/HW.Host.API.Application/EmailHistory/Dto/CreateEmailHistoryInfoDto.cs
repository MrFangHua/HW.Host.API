namespace HW.Host.API.Application.EmailHistory.Dto
{
    /// <summary>
    /// 添加邮件历史信息类
    /// </summary>
    public class createEmailHistoryInfoDto
    {
        /// <summary>
        /// 收件人账号
        /// </summary>
        public string RecipientId { get; set; }

        /// <summary>
        /// 邮件内容
        /// </summary>
        public string EmailBody { get; set; }

        /// <summary>
        /// 是否发送邮件，默认为发送
        /// </summary>
        public bool IsSendEmail { get; set; } = true;
    }
}