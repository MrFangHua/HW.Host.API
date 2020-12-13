using HW.Host.API.Infrastructure.Model;
using System.Collections.Generic;

namespace HW.Host.API.Application.ReportMealInfo.Dto
{
    /// <summary>
    /// 得到所有的报餐信息返回结果
    /// </summary>
    public class GetAllReportMealInfoResultDto : ResultDto
    {
        /// <summary>
        /// 明天报餐信息
        /// </summary>
        public List<ReportMeal> NextReportMealInfoList { get; set; }

        /// <summary>
        /// 明天中餐人数
        /// </summary>
        public int NextLunchCount { get; set; }

        /// <summary>
        /// 明天晚餐人数
        /// </summary>
        public int NextDinnerCount { get; set; }

        /// <summary>
        /// 当天报餐信息
        /// </summary>
        public List<ReportMeal> CurrentReportMealInfoList { get; set; }

        /// <summary>
        /// 当天中餐人数
        /// </summary>
        public int CurrentLunchCount { get; set; }

        /// <summary>
        /// 当天晚餐人数
        /// </summary>
        public int CurrentDinnerCount { get; set; }
    }
}