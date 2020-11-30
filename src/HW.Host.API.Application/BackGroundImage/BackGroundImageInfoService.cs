using HW.Host.API.Infrastructure.SqlSugar;
using HW.Host.API.Model.ModelEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HW.Host.API.Application.BackGroundImage
{
    /// <summary>
    /// 背景图片服务
    /// </summary>
    [ApiExplorerSettings(GroupName = "HW.Host.App.API")]
    [Route("api/BackGroundImageInfoService")]
    [ApiController]
    [Authorize]
    public class BackGroundImageInfoService
    {
        private readonly IOwnerRepository<HW_BackGroundImageInfo> _context;

        public BackGroundImageInfoService(IOwnerRepository<HW_BackGroundImageInfo> context)
        {
            _context = context;
        }

        /// <summary>
        /// 得到所有背景图片信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllBackGroundImageInfo")]
        [AllowAnonymous]
        public async Task<List<HW_BackGroundImageInfo>> GetAllBackGroundImageInfo()
        {
            return await _context.GetAll();
        }
    }
}