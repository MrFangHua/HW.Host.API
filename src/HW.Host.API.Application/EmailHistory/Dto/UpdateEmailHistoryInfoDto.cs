﻿using System.ComponentModel.DataAnnotations;

namespace HW.Host.API.Application.EmailHistory.Dto
{
    /// <summary>
    /// 修改邮件历史信息类
    /// </summary>
    public class UpdateEmailHistoryInfoDto
    {
        /// <summary>
        /// Id
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// 邮件内容
        /// </summary>
        [Required]
        public string EmailBody { get; set; }
    }
}