namespace HW.Host.API.Application.PhoneModelInfo.Dto
{
    /// <summary>
    /// 手机模型信息
    /// </summary>
    public class PhoneModelInfoDto
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

        private string phoneLeaseTime;

        /// <summary>
        /// 租凭时间
        /// </summary>
        public string PhoneLeaseTime { get { return phoneLeaseTime; } set { phoneLeaseTime = value == "1-01-1 0:0:0" || value == "1753-01-1 0:0:0" ? "" : value; } }

        /// <summary>
        /// 是否归还（租赁归还）
        /// </summary>
        public int PhoneIsReturn { get; set; }

        private string phoneReturnTime;

        /// <summary>
        /// 归还时间（租赁归还）
        /// </summary>
        public string PhoneReturnTime { get { return phoneReturnTime; } set { phoneReturnTime = value == "1-01-1 0:0:0" || value == "1753-01-1 0:0:0" ? "" : value; } }

        /// <summary>
        /// 备注
        /// </summary>
        public string PhoneRemarks { get; set; }

        /// <summary>
        /// 手机归还备注
        /// </summary>
        public string PhoneReturnRemarks { get; set; }

        private string receiveTime;

        /// <summary>
        /// 领取时间
        /// </summary>
        public string ReceiveTime { get { return receiveTime; } set { receiveTime = value == "1-01-1 0:0:0" || value == "1753-01-1 0:0:0" ? "" : value; } }

        /// <summary>
        /// 领取员工ID
        /// </summary>
        public int ReceiveUserID { get; set; }

        /// <summary>
        /// 领取员工名称
        /// </summary>
        public string ReceiveUserName { get; set; }

        /// <summary>
        /// 是否归还
        /// </summary>
        public int ReceiveIsReturn { get; set; }

        private string receiveReturnTime;

        /// <summary>
        /// 归还时间
        /// </summary>
        public string ReceiveReturnTime { get { return receiveReturnTime; } set { receiveReturnTime = value == "1-01-1 0:0:0" || value == "1753-01-1 0:0:0" ? "" : value; } }

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