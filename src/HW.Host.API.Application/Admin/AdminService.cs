using HW.Host.API.Application.Admin.Dto;
using HW.Host.API.Infrastructure.Authorization.Jwt;
using HW.Host.API.Infrastructure.SqlSugar;
using HW.Host.API.Model.DefaultEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HW.Host.API.Application.Admin
{
    /// <summary>
    /// 管理员服务
    /// </summary>
    [ApiExplorerSettings(GroupName = "HW.Host.Admin.API")]
    [Route("api/AdminService")]
    [ApiController]
    [Authorize]
    public class AdminService
    {
        private readonly IOwnerRepository<HW_Admin> _context;

        public AdminService(IOwnerRepository<HW_Admin> repository)
        {
            _context = repository;
        }

        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="adminLoginDto">管理员登陆实体类</param>
        /// <returns></returns>
        [HttpPost("AdminLogin")]
        [AllowAnonymous]
        public async Task<AdminLoginResultDto> AdminLogin(AdminLoginDto adminLoginDto)
        {
            // 判断是否为空
            adminLoginDto.ISNullOrEmpty();
            var result = await _context
                .GetFirstOrDefault(a =>
                a.AdminName.Equals(adminLoginDto.AdminName) &&
                a.AdminPwd.Equals(adminLoginDto.AdminPwd));
            if (result != null)
                return new AdminLoginResultDto() { ResultInfo = "Bearer " + JwtService.GetToken(adminLoginDto.AdminName) };
            else
                // 账号或密码错误
                throw new Exception("Incorrect username or password.");
        }

        /// <summary>
        /// 查询所有Admin
        /// </summary>
        /// <returns></returns>
        [HttpGet("SellectAll")]
        public async Task<List<HW_Admin>> SellectAll()
        {
            return await _context.GetAll();
        }
    }
}