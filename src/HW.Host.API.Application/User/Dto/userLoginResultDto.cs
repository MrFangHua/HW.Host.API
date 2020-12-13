using HW.Host.API.Infrastructure.Model;

namespace HW.Host.API.Application.User.Dto
{
    /// <summary>
    /// 用户登录返回结果类
    /// </summary>
    public class UserLoginResultDto : ResultDto
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }
    }
}