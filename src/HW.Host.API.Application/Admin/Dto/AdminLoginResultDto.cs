using HW.Host.API.Infrastructure.Model;

namespace HW.Host.API.Application.Admin.Dto
{
    /// <summary>
    /// 用户登录返回结果
    /// </summary>
    public class AdminLoginResultDto : ResultDto
    {
        /// <summary>
        /// 管理员Id
        /// </summary>
        public int AdminId { get; set; }
    }
}