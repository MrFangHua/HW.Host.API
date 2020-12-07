using HW.Host.API.Application.PhoneModelInfo.Dto;
using HW.Host.API.Infrastructure.Model;
using HW.Host.API.Infrastructure.SqlSugar;
using HW.Host.API.Model.DefaultEntity;
using HW.Host.API.Model.ModelEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using System.Linq;
using System.Threading.Tasks;

namespace HW.Host.API.Application.PhoneModelInfo
{
    /// <summary>
    /// 手机型号服务
    /// </summary>
    [ApiExplorerSettings(GroupName = "HW.Host.App.API")]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PhoneModelInfoService
    {
        private readonly IOwnerRepository<HW_PhoneModelInfo> _context;

        public PhoneModelInfoService(IOwnerRepository<HW_PhoneModelInfo> context)
        {
            _context = context;
        }

        /// <summary>
        /// 添加手机型号
        /// </summary>
        /// <param name="model">手机型号</param>
        /// <returns></returns>
        [HttpPost("AddPhoneModel")]
        public async Task<ResultDto> AddPhoneModel(HW_PhoneModelInfo model)
        {
            return new ResultDto() { Success = await _context.Add(model) };
        }

        /// <summary>
        /// 根据手机型号Id得到手机型号详情
        /// </summary>
        /// <param name="PhoneId">手机型号Id</param>
        /// <returns></returns>
        [HttpGet("GetAllPhoneModel")]
        public async Task<GetAllPhoneModelResultDto> GetAllPhoneModel(int PhoneId)
        {
            var result = await _context.Db
                .Queryable<HW_PhoneModelInfo, HW_PhoneReceiveInfo, HW_Users>(
                (pm, pi, u) => new JoinQueryInfos(
                    JoinType.Left, pm.Id == pi.ReceivePhoneModelID,
                    JoinType.Left, pi.ReceiveUserID == u.Id))
                .Where(pm => pm.Id == PhoneId)
                .OrderBy((pm, pi) => pi.ReceiveTime, OrderByType.Desc)
                .Select((pm, pi, u) => new PhoneModelInfoDto
                {
                    Id = pm.Id,
                    PhoneName = pm.PhoneName,
                    PhoneRAM = pm.PhoneRAM,
                    PhonePrice = pm.PhonePrice,
                    PhoneFineness = pm.PhoneFineness,
                    PhoneColour = pm.PhoneColour,
                    PhoneCode = pm.PhoneCode,
                    PhoneLeaseTime = pm.PhoneLeaseTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    PhoneIsReturn = pm.PhoneIsReturn,
                    PhoneReturnTime = pm.PhoneReturnTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    PhoneRemarks = pm.PhoneRemarks,
                    PhoneReturnRemarks = pm.PhoneReturnRemarks,
                    ReceiveTime = pi.ReceiveTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    ReceiveUserID = pi.ReceiveUserID,
                    ReceiveUserName = u.UserName,
                    ReceiveIsReturn = pi.ReceiveIsReturn,
                    ReceiveReturnTime = pi.ReceiveReturnTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    ReceiveRemarks = pi.ReceiveRemarks,
                    ReturnRemarks = pi.ReturnRemarks
                }).FirstAsync();
            return new GetAllPhoneModelResultDto()
            {
                PhoneModel = result
            };
        }

        /// <summary>
        /// 得到所有手机型号详情
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllPhoneModelInfo")]
        public async Task<GetAllPhoneModelInfoResultDto> GetAllPhoneModelInfo()
        {
            var result = await _context.Db
                .Queryable<HW_PhoneModelInfo, HW_PhoneReceiveInfo, HW_Users>(
                (pm, pi, u) => new JoinQueryInfos(
                    JoinType.Left, pm.Id == pi.ReceivePhoneModelID,
                    JoinType.Left, pi.ReceiveUserID == u.Id))
                .OrderBy((pm, pi) => pi.ReceiveTime, OrderByType.Desc)
                .Select((pm, pi, u) => new PhoneModelInfoDto
                {
                    Id = pm.Id,
                    PhoneName = pm.PhoneName,
                    PhoneRAM = pm.PhoneRAM,
                    PhonePrice = pm.PhonePrice,
                    PhoneFineness = pm.PhoneFineness,
                    PhoneColour = pm.PhoneColour,
                    PhoneCode = pm.PhoneCode,
                    PhoneLeaseTime = pm.PhoneLeaseTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    PhoneIsReturn = pm.PhoneIsReturn,
                    PhoneReturnTime = pm.PhoneReturnTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    PhoneRemarks = pm.PhoneRemarks,
                    PhoneReturnRemarks = pm.PhoneReturnRemarks,
                    ReceiveTime = pi.ReceiveTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    ReceiveUserID = pi.ReceiveUserID,
                    ReceiveUserName = u.UserName,
                    ReceiveIsReturn = pi.ReceiveIsReturn,
                    ReceiveReturnTime = pi.ReceiveReturnTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    ReceiveRemarks = pi.ReceiveRemarks,
                    ReturnRemarks = pi.ReturnRemarks
                }).ToListAsync();
            // 重复Id分组，并且只取出每组的第一条
            var resultGB = result.GroupBy(groups => groups.Id)
                .Select(groups => groups.FirstOrDefault())
                .ToList();
            return new GetAllPhoneModelInfoResultDto()
            {
                PhoneModelList = resultGB
            };
        }
    }
}