using System;

namespace HW.Host.API.Application.User.Dto
{
    /// <summary>
    /// 得到所有用户名称
    /// </summary>
    public class GetAllUserNameResultDto
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public String UserName { get; set; }
    }
}