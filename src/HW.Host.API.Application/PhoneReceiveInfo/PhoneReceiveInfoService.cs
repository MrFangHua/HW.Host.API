using HW.Host.API.Application.PhoneReceiveInfo.Dto;
using HW.Host.API.Infrastructure.SqlSugar;
using HW.Host.API.Model.ModelEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HW.Host.API.Application.PhoneReceiveInfo
{
    /// <summary>
    /// 手机领取服务
    /// </summary>
    [ApiExplorerSettings(GroupName = "HW.Host.App.API")]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PhoneReceiveInfoService
    {
        private readonly IOwnerRepository<HW_PhoneReceiveInfo> _context;

        public PhoneReceiveInfoService(IOwnerRepository<HW_PhoneReceiveInfo> context)
        {
            _context = context;
        }

        /// <summary>
        /// 得到所有手机领取详情信息
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPhoneReceiveInfo")]
        public async Task<GetAllPhoneReceiveInfoResultDto> GetAllPhoneReceiveInfo()
        {
            return new GetAllPhoneReceiveInfoResultDto();
        }
    }
}