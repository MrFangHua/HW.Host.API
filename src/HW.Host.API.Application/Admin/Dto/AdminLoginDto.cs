using System;

namespace HW.Host.API.Application.Admin.Dto
{
    /// <summary>
    /// 管理员登陆
    /// </summary>
    public class AdminLoginDto
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string AdminName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string AdminPwd { get; set; }

        /// <summary>
        /// 账号是否为空
        /// </summary>
        public void AdminNameISNullOrEmpty()
        {
            if (string.IsNullOrEmpty(this.AdminName))
            {
                // 账号不能为空
                throw new Exception("Account cannot be empty.");
            }
        }

        /// <summary>
        /// 密码是否为空
        /// </summary>
        public void AdminPwdISNullOrEmpty()
        {
            if (string.IsNullOrEmpty(this.AdminPwd))
            {
                // 密码不能为空
                throw new Exception("Password cannot be empty.");
            }
        }

        /// <summary>
        /// 账号和密码不能为空
        /// </summary>
        public void ISNullOrEmpty()
        {
            this.AdminNameISNullOrEmpty();
            this.AdminPwdISNullOrEmpty();
        }
    }
}