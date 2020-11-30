using HW.Host.API.Infrastructure.SqlSugar;
using HW.Host.API.Model.LogEntity;

namespace HW.Host.API.Application.SqlLog
{
    /// <summary>
    /// 日志服务
    /// </summary>
    //[ApiExplorerSettings(GroupName = "HW.Host.Admin.API")]
    //[Route("api/[controller]")]
    //[ApiController]
    public class LogService
    {
        private readonly ILogRepository<HW_Log> _context;

        public LogService(ILogRepository<HW_Log> repository)
        {
            _context = repository;
        }
    }
}