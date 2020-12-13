using HW.Host.API.Application.ReportMealInfo.Dto;
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

namespace HW.Host.API.Application.ReportMealInfo
{
    /// <summary>
    /// 报餐信息服务
    /// </summary>
    [ApiExplorerSettings(GroupName = "HW.Host.App.API")]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReportMealInfoService
    {
        private readonly IOwnerRepository<HW_ReportMealInfo> _context;

        public ReportMealInfoService(IOwnerRepository<HW_ReportMealInfo> context)
        {
            _context = context;
        }

        /// <summary>
        /// 根据员工Id得到所有的报餐信息
        /// </summary>
        /// <param name="UserId">员工Id</param>
        /// <returns></returns>
        [HttpGet("GetAllReportMealInfoByUserId")]
        public async Task<GetAllReportMealInfoByUserIdResultDto> GetAllReportMealInfoByUserId(int UserId)
        {
            var result = await _context.Db.Queryable<HW_ReportMealInfo, HW_Users>(
                (rm, u) => new JoinQueryInfos(
                    JoinType.Left, rm.CreateUserID == u.Id))
                .Where((rm, u) => rm.IsDeleted == 0 &&
                    rm.ReportMealUserID == UserId &&
                    DateTime.Parse(rm.ReportMealTime) >= DateTime.Parse(DateTime.Now.ToShortDateString()))
                .OrderBy((rm, u) => rm.ReportMealTime)
                .Select((rm, u) => new ReportMeal
                {
                    Id = rm.Id,
                    ReportMealTime = rm.ReportMealTime,
                    Lunch = rm.Lunch,
                    Dinner = rm.Dinner,
                    Meal = "餐详情"
                }).ToListAsync();
            return new GetAllReportMealInfoByUserIdResultDto()
            {
                ReportMealInfoList = result,
                Count = result.Count
            };
        }

        /// <summary>
        /// 得到所有的报餐信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllReportMealInfo")]
        public async Task<GetAllReportMealInfoResultDto> GetAllReportMealInfo()
        {
            var result = await _context.Db.Queryable<HW_ReportMealInfo, HW_Users>(
                (rm, u) => new JoinQueryInfos(
                    JoinType.Left, rm.ReportMealUserID == u.Id))
                .Where((rm, u) => rm.IsDeleted == 0 &&
                    DateTime.Parse(rm.ReportMealTime) >= DateTime.Parse(DateTime.Now.ToShortDateString()) &&
                    DateTime.Parse(rm.ReportMealTime) <= DateTime.Parse(DateTime.Now.AddDays(1).ToShortDateString()))
                .OrderBy((rm, u) => rm.ReportMealTime)
                .Select((rm, u) => new ReportMeal
                {
                    Id = rm.Id,
                    ReportMealTime = rm.ReportMealTime,
                    ReportMealUserName = u.UserName,
                    Lunch = rm.Lunch,
                    Dinner = rm.Dinner,
                    Meal = "餐详情"
                }).ToListAsync();
            var currentReportMealInfoList = result.Where(res => DateTime.Parse(res.ReportMealTime) == DateTime.Parse(DateTime.Now.ToShortDateString())).ToList();
            var nextReportMealInfoList = result.Where(res => DateTime.Parse(res.ReportMealTime) == DateTime.Parse(DateTime.Now.AddDays(1).ToShortDateString())).ToList();
            return new GetAllReportMealInfoResultDto()
            {
                CurrentReportMealInfoList = currentReportMealInfoList,
                CurrentLunchCount = currentReportMealInfoList.Where(where => where.Lunch == 1).Count(),
                CurrentDinnerCount = currentReportMealInfoList.Where(where => where.Dinner == 1).Count(),
                NextReportMealInfoList = nextReportMealInfoList,
                NextLunchCount = nextReportMealInfoList.Where(where => where.Lunch == 1).Count(),
                NextDinnerCount = nextReportMealInfoList.Where(where => where.Dinner == 1).Count()
            };
        }

        /// <summary>
        /// 添加报餐信息
        /// </summary>
        /// <returns></returns>
        [HttpPost("AddReportMealInfo")]
        public async Task<ResultDto> AddReportMealInfo(List<ReportMeal> model)
        {
            var result = await _context.GetByWhere(where => where.IsDeleted == 0 && where.ReportMealUserID.Equals(model[0].ReportMealUserId));
            foreach (var meal in model)
            {
                if (result.Where(where => where.ReportMealTime.Equals(meal.ReportMealTime)).ToList().Count > 0)
                {
                    // 这一天已经报餐，请重新选择一天进行报餐。
                    throw new Exception(string.Format("【{0}】Meals have been reported on this day, please select a new day to report meals.", meal.ReportMealTime));
                }
            }
            var addModel = model.Select(
                m => new HW_ReportMealInfo()
                {
                    ReportMealUserID = m.ReportMealUserId,
                    ReportMealTime = m.ReportMealTime,
                    Lunch = m.Lunch,
                    Dinner = m.Dinner
                }).ToList();
            return new ResultDto()
            {
                Success = await _context.AddRange(addModel)
            };
        }

        /// <summary>
        /// 根据主键ID修改报餐信息
        /// </summary>
        /// <param name="model">报餐信息</param>
        /// <returns></returns>
        [HttpPut("UpdateReportMealInfo")]
        public async Task<ResultDto> UpdateReportMealInfo(ReportMeal model)
        {
            var result = await _context.GetFirstOrDefault(where => where.Id.Equals(model.Id));
            if (result != null)
            {
                result.Lunch = model.Lunch;
                result.Dinner = model.Dinner;
                return new ResultDto() { Success = await _context.Update(result) };
            }
            else
            {
                // 系统错误。
                throw new Exception("System error.");
            }
        }

        /// <summary>
        /// 根据Id删除报餐信息
        /// </summary>
        /// <param name="Id">Id</param>
        /// <returns></returns>
        [HttpDelete("DeleteReportMealInfo")]
        public async Task<ResultDto> DeleteReportMealInfo(int Id)
        {
            var result = await _context.GetFirstOrDefault(where => where.Id.Equals(Id));
            result.IsDeleted = 1;
            return new ResultDto() { Success = await _context.Update(result) };
        }
    }
}