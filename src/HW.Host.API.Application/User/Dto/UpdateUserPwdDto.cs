using System;

namespace HW.Host.API.Application.User.Dto
{
    /// <summary>
    /// 修改用户密码
    /// </summary>
    public class UpdateUserPwdDto
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 旧密码
        /// </summary>
        public string UserOldPwd { get; set; }

        /// <summary>
        /// 新密码
        /// </summary>
        public string UserNewPwd { get; set; }

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
            if (string.IsNullOrEmpty(this.UserOldPwd))
            {
                // 密码不能为空
                throw new Exception("Old password cannot be empty.");
            }
        }

        /// <summary>
        /// 新密码是否为空
        /// </summary>
        public void UserNewPwdISNullOrEmpty()
        {
            if (string.IsNullOrEmpty(this.UserNewPwd))
            {
                // 新密码不能为空
                throw new Exception("New password cannot be empty.");
            }
        }

        /// <summary>
        /// 账号和密码不能为空
        /// </summary>
        public void ISNullOrEmpty()
        {
            this.UserNameISNullOrEmpty();
            this.UserPwdISNullOrEmpty();
            this.UserNewPwdISNullOrEmpty();
        }
    }
}