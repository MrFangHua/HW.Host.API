using HW.Host.API.Application.User.Dto;
using HW.Host.API.Infrastructure.Authorization.Jwt;
using HW.Host.API.Infrastructure.Model;
using HW.Host.API.Infrastructure.SqlSugar;
using HW.Host.API.Model.DefaultEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HW.Host.API.Application.User
{
    /// <summary>
    /// 用户服务
    /// </summary>
    [ApiExplorerSettings(GroupName = "HW.Host.Admin.API")]
    [Route("api/UserService")]
    [ApiController]
    [Authorize]
    public class UserService
    {
        private readonly IOwnerRepository<HW_Users> _context;

        public UserService(IOwnerRepository<HW_Users> repository)
        {
            _context = repository;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userLoginDto">用户登陆实体类</param>
        /// <returns></returns>
        [HttpPost("UserLogin")]
        [AllowAnonymous]
        public async Task<UserLoginResultDto> UserLogin(UserLoginDto userLoginDto)
        {
            // 判断是否为空
            userLoginDto.ISNullOrEmpty();
            // 检查安全码
            userLoginDto.CheckSecurityCode();
            var result = await _context
                .GetFirstOrDefault(a =>
                a.UserName.Equals(userLoginDto.UserName) &&
                a.UserPwd.Equals(userLoginDto.UserPwd));
            if (result != null)
                return new UserLoginResultDto() { UserId = result.Id, ResultInfo = "Bearer " + JwtService.GetToken(userLoginDto.UserName) };
            else
                // 账号或密码错误
                throw new Exception("Incorrect username or password.");
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="userLoginDto">用户登陆实体类</param>
        /// <returns></returns>
        [HttpPost("AddUser")]
        public async Task<ResultDto> AddUser(UserLoginDto userLoginDto)
        {
            userLoginDto.ISNullOrEmpty();
            return new ResultDto() { Success = await _context.Add(new HW_Users() { UserName = userLoginDto.UserName, UserPwd = userLoginDto.UserPwd }) };
        }

        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="updateUserPwdDto">修改用户密码实体类</param>
        /// <returns></returns>
        [HttpPut("UpdateUserPwd")]
        [AllowAnonymous]
        public async Task<ResultDto> UpdateUserPwd(UpdateUserPwdDto updateUserPwdDto)
        {
            updateUserPwdDto.ISNullOrEmpty();
            var result = await _context
               .GetFirstOrDefault(a =>
               a.UserName.Equals(updateUserPwdDto.UserName) &&
               a.UserPwd.Equals(updateUserPwdDto.UserOldPwd));
            if (result != null)
            {
                // 修改密码
                result.UserPwd = updateUserPwdDto.UserNewPwd;
                return new ResultDto() { Success = await _context.Update(result) };
            }
            else
            {
                // 账号或密码错误
                throw new Exception("Incorrect username or password.");
            }
        }

        /// <summary>
        /// 得到所有用户名称
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllUserName")]
        [AllowAnonymous]
        public async Task<List<GetAllUserNameResultDto>> GetAllUserName()
        {
            // 拿到只有Id和UserName的所有用户
            return await _context.Db
                .Queryable<HW_Users>()
                .Select(u => new GetAllUserNameResultDto { Id = u.Id, UserName = u.UserName })
                .ToListAsync();
        }
    }
}