using HW.Host.API.Infrastructure.SqlSugar;
using HW.Host.API.Model.ModelEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HW.Host.API.Application.Copywriting
{
    /// <summary>
    /// 文案服务
    /// </summary>
    [ApiExplorerSettings(GroupName = "HW.Host.App.API")]
    [Route("api/CopywritingInfoService")]
    [ApiController]
    [Authorize]
    public class CopywritingInfoService
    {
        private readonly IOwnerRepository<HW_CopywritingInfo> _context;

        public CopywritingInfoService(IOwnerRepository<HW_CopywritingInfo> context)
        {
            _context = context;
        }

        /// <summary>
        /// 得到所有文案
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllCopywritingInfo")]
        [AllowAnonymous]
        public async Task<List<HW_CopywritingInfo>> GetAllCopywritingInfo()
        {
            return await _context.GetAll();
        }
    }
}