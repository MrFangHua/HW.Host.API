using HW.Host.API.Infrastructure.Model;

namespace HW.Host.API.Application.PhoneModelInfo.Dto
{
    /// <summary>
    /// 得到手机模型返回类
    /// </summary>
    public class GetAllPhoneModelResultDto : ResultDto
    {
        /// <summary>
        /// 手机型号集合
        /// </summary>
        public PhoneModelInfoDto PhoneModel { get; set; }
    }
}