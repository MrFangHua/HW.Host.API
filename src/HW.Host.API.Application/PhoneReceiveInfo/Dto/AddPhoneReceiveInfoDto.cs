namespace HW.Host.API.Application.PhoneReceiveInfo.Dto
{
    /// <summary>
    /// 添加手机领取信息实体类
    /// </summary>
    public class AddPhoneReceiveInfoDto
    {
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
        /// 领取备注
        /// </summary>
        public string ReceiveRemarks { get; set; }
    }
}