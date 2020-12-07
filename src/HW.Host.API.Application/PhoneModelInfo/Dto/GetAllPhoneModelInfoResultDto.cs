using HW.Host.API.Infrastructure.Model;
using System.Collections.Generic;

namespace HW.Host.API.Application.PhoneModelInfo.Dto
{
    public class GetAllPhoneModelInfoResultDto : ResultDto
    {
        /// <summary>
        /// 手机型号集合
        /// </summary>
        public List<PhoneModelInfoDto> PhoneModelList { get; set; }
    }
}