using System;
using System.Collections.Generic;
using System.Text;

namespace HW.Host.API.Application.PhoneReceiveInfo.Dto
{
    /// <summary>
    /// 修改手机领取信息实体类
    /// </summary>
    public class UpdatePhoneReceiveInfoDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 是否归还
        /// </summary>
        public int ReceiveIsReturn { get; set; } = 1;

        /// <summary>
        /// 归还时间
        /// </summary>
        public DateTime ReceiveReturnTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 归还备注
        /// </summary>
        public string ReturnRemarks { get; set; }
    }
}