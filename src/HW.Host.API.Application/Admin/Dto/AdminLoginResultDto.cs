using HW.Host.API.Infrastructure.Model;

namespace HW.Host.API.Application.Admin.Dto
{
    /// <summary>
    /// 用户登录返回结果
    /// </summary>
    public class AdminLoginResultDto : ResultDto
    {
        /// <summary>
        /// 是否为管理员
        /// </summary>
        public int ISAdmin { get; set; } = 0;
    }
}