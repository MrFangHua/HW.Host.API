using HW.Host.API.Infrastructure.Model;
using System.Collections.Generic;

namespace HW.Host.API.Application.ReportMealInfo.Dto
{
    /// <summary>
    /// 根据员工Id得到所有的报餐信息返回结果
    /// </summary>
    public class GetAllReportMealInfoByUserIdResultDto : ResultDto
    {
        /// <summary>
        /// 当前员工的报餐信息
        /// </summary>
        public List<ReportMeal> ReportMealInfoList { get; set; }

        /// <summary>
        /// 当前员工的报餐信息
        /// </summary>
        public int Count { get; set; }
    }
}