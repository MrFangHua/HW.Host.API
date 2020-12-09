using HW.Host.API.Infrastructure.Model;
using System.Collections.Generic;

namespace HW.Host.API.Application.PhoneModelInfo.Dto
{
    /// <summary>
    /// 得到手机模型返回类（领取）
    /// </summary>
    public class GetAllPhoneModelResultDto : ResultDto
    {
        /// <summary>
        /// 手机型号集合
        /// </summary>
        public List<PhoneModelDto> PhoneModelList { get; set; }
    }

    /// <summary>
    /// 手机模型（领取）
    /// </summary>
    public class PhoneModelDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 手机型号
        /// </summary>
        public string PhoneName { get; set; }

        /// <summary>
        /// 手机内存
        /// </summary>
        public string PhoneRAM { get; set; }

        /// <summary>
        /// 手机价格
        /// </summary>
        public int PhonePrice { get; set; }

        /// <summary>
        /// 手机成色
        /// </summary>
        public string PhoneFineness { get; set; }

        /// <summary>
        /// 手机颜色
        /// </summary>
        public string PhoneColour { get; set; }

        /// <summary>
        /// 手机串码
        /// </summary>
        public string PhoneCode { get; set; }

        /// <summary>
        /// 是否归还
        /// </summary>
        public int ReceiveIsReturn { get; set; } = 1;

        private string receiveReturnTime;

        /// <summary>
        /// 归还时间
        /// </summary>
        public string ReceiveReturnTime { get { return receiveReturnTime; } set { receiveReturnTime = value == "1-01-1 0:0:0" || value == "1753-01-1 0:0:0" ? "" : value; } }
    }
}