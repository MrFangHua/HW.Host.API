using HW.Host.API.Application.PhoneModelInfo.Dto;
using HW.Host.API.Application.PhoneReceiveInfo.Dto;
using HW.Host.API.Infrastructure.Model;
using HW.Host.API.Infrastructure.SqlSugar;
using HW.Host.API.Model.DefaultEntity;
using HW.Host.API.Model.ModelEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
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
        /// 根据手机型号Id得到手机型号领取历史记录详情
        /// </summary>
        /// <param name="PhoneId">手机型号Id</param>
        /// <returns></returns>
        [HttpGet("GetPhoneModelReceiveInfoByPhoneId")]
        public async Task<GetAllPhoneModelInfoResultDto> GetPhoneModelReceiveInfoByPhoneId(int PhoneId)
        {
            var result = await _context.Db
                .Queryable<HW_PhoneReceiveInfo, HW_PhoneModelInfo, HW_Users>(
                (pi, pm, u) => new JoinQueryInfos(
                    JoinType.Left, pi.ReceivePhoneModelID == pm.Id,
                    JoinType.Left, pi.ReceiveUserID == u.Id))
                .Where(pi => pi.IsDeleted == 0)
                .Where(pi => pi.ReceivePhoneModelID == PhoneId)
                .OrderBy((pi, pm) => pi.ReceiveTime, OrderByType.Desc)
                .Select((pi, pm, u) => new PhoneModelInfoDto
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
            return new GetAllPhoneModelInfoResultDto()
            {
                PhoneModelList = result
            };
        }

        /// <summary>
        /// 添加手机领取详情信息
        /// </summary>
        /// <param name="modelList">手机领取实体类集合</param>
        /// <returns></returns>
        [HttpPost("AddPhoneReceiveInfo")]
        public async Task<ResultDto> AddPhoneReceiveInfo(List<AddPhoneReceiveInfoDto> modelList)
        {
            // 判断是否有未归还的手机
            var result = await GetPhoneReceiveInfoByUserId(modelList[0].ReceiveUserID);
            if (result.PhoneModelList.Count > 0)
            {
                // 当前用户领取手机未归还，请先归还再做处理。
                throw new Exception("The current user picks up the mobile phone and has not returned it. Please return it before processing.");
            }
            return new ResultDto
            {
                Success =
                await _context.AddRange(ModelBindingService.CopyModelList<HW_PhoneReceiveInfo, AddPhoneReceiveInfoDto>(modelList))
            };
        }

        /// <summary>
        /// 修改手机领取详情信息
        /// </summary>
        /// <param name="modelList">手机领取修改实体类集合</param>
        /// <returns></returns>
        [HttpPut("UpdatePhoneReceiveInfo")]
        public async Task<ResultDto> UpdatePhoneReceiveInfo(List<UpdatePhoneReceiveInfoDto> modelList)
        {
            var idList = modelList.Select(model => model.Id).ToList();
            // 根据ID查询
            var resultModel = await _context.GetByIn(idList);
            // 修改数据
            var updateModel = resultModel.Join(modelList, m => m.Id, ml => ml.Id, (m, ml) => new HW_PhoneReceiveInfo
            {
                Id = m.Id,
                ReceiveTime = m.ReceiveTime,
                ReceiveUserID = m.ReceiveUserID,
                ReceivePhoneModelID = m.ReceivePhoneModelID,
                ReceiveIsReturn = ml.ReceiveIsReturn,
                ReceiveReturnTime = ml.ReceiveReturnTime,
                ReceiveRemarks = m.ReceiveRemarks,
                ReturnRemarks = ml.ReturnRemarks,
                IsDeleted = m.IsDeleted,
                CreateUserID = m.CreateUserID,
                CreateAdminID = m.CreateAdminID,
                CreateTime = m.CreateTime,
                LastUpdateTime = m.LastUpdateTime,
                DeleteTimeAndRemark = m.DeleteTimeAndRemark
            }).ToList();
            return new ResultDto
            {
                Success = await _context.UpdateRange(updateModel)
            };
        }

        /// <summary>
        /// 根据用户Id得到手机领取信息
        /// </summary>
        /// <param name="UserId">用户Id</param>
        /// <returns></returns>
        [HttpGet("GetPhoneReceiveInfoByUserId")]
        public async Task<GetAllPhoneModelInfoResultDto> GetPhoneReceiveInfoByUserId(int UserId)
        {
            var result = await _context.Db
                .Queryable<HW_PhoneReceiveInfo, HW_PhoneModelInfo, HW_Users>(
                (pi, pm, u) => new JoinQueryInfos(
                    JoinType.Left, pi.ReceivePhoneModelID == pm.Id,
                    JoinType.Left, pi.ReceiveUserID == u.Id))
                .Where(pi => pi.IsDeleted == 0)
                .Where(pi => pi.ReceiveUserID == UserId && pi.ReceiveIsReturn == 0)
                .OrderBy((pi, pm) => pi.ReceiveTime, OrderByType.Desc)
                .Select((pi, pm, u) => new PhoneModelInfoDto
                {
                    Id = pm.Id,
                    PhoneName = pm.PhoneName,
                    PhoneRAM = pm.PhoneRAM,
                    PhonePrice = pm.PhonePrice,
                    PhoneFineness = pm.PhoneFineness,
                    PhoneColour = pm.PhoneColour,
                    PhoneCode = pm.PhoneCode,
                    PhoneLeaseTime = pm.PhoneLeaseTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    PhoneRemarks = pm.PhoneRemarks,
                    ReceiveTime = pi.ReceiveTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    ReceiveUserID = pi.ReceiveUserID,
                    ReceiveUserName = u.UserName,
                    ReceiveRemarks = pi.ReceiveRemarks,
                }).ToListAsync();
            return new GetAllPhoneModelInfoResultDto()
            {
                PhoneModelList = result
            };
        }
    }
}