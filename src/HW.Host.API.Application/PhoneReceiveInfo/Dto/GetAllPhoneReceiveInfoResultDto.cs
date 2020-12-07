using HW.Host.API.Infrastructure.Model;
using HW.Host.API.Model.ModelEntity;
using System;
using System.Collections.Generic;

namespace HW.Host.API.Application.PhoneReceiveInfo.Dto
{
    /// <summary>
    /// 得到所有手机领取详情返回类
    /// </summary>
    public class GetAllPhoneReceiveInfoResultDto : ResultDto
    {
        /// <summary>
        /// 手机领取信息集合
        /// </summary>
        public List<HW_PhoneReceiveInfo> PhoneReceiveInfoList { get; set; }

        /// <summary>
        /// 手机领取信息
        /// </summary>
        public class PhoneReceiveInfo
        {
            /// <summary>
            /// Id
            /// </summary>
            public int Id { get; set; }

            /// <summary>
            /// 领取时间
            /// </summary>
            public DateTime ReceiveTime { get; set; } = DateTime.Now;

            /// <summary>
            /// 领取员工ID
            /// </summary>
            public int ReceiveUserID { get; set; }

            /// <summary>
            /// 领取型号详情ID
            /// </summary>
            public int ReceivePhoneModelID { get; set; }

            /// <summary>
            /// 是否归还
            /// </summary>
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
}