using HW.Host.API.Infrastructure.AppConfigurtaion;
using System;

namespace HW.Host.API.Application.User.Dto
{
    /// <summary>
    /// 用户登陆
    /// </summary>
    public class UserLoginDto
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string UserPwd { get; set; }

        /// <summary>
        /// 安全码
        /// </summary>
        public string SecurityCode { get; set; }

        /// <summary>
        /// 账号是否为空
        /// </summary>
        public void UserNameISNullOrEmpty()
        {
            if (string.IsNullOrEmpty(this.UserName))
            {
                // 账号不能为空
                throw new Exception("Account cannot be empty.");
            }
        }

        /// <summary>
        /// 密码是否为空
        /// </summary>
        public void UserPwdISNullOrEmpty()
        {
            if (string.IsNullOrEmpty(this.UserPwd))
            {
                // 密码不能为空
                throw new Exception("Password cannot be empty.");
            }
        }

        /// <summary>
        /// 安全码是否为空
        /// </summary>
        public void SecurityCodeISNullOrEmpty()
        {
            if (string.IsNullOrEmpty(this.SecurityCode))
            {
                // 安全码不能为空
                throw new Exception("SecurityCode cannot be empty.");
            }
        }

        /// <summary>
        /// 账号和密码不能为空
        /// </summary>
        public void ISNullOrEmpty()
        {
            this.UserNameISNullOrEmpty();
            this.UserPwdISNullOrEmpty();
        }

        /// <summary>
        /// 判断安全码是否正确
        /// </summary>
        public void CheckSecurityCode()
        {
            this.SecurityCodeISNullOrEmpty();
            var code = AppConfigurtaionService.Configuration["ProjectInfo:SecurityCode"];
            if (code != this.SecurityCode)
            {
                // 安全码不正确
                throw new Exception("Incorrect security code.");
            }
        }
    }
}