using HW.Host.API.Infrastructure.SqlSugar;
using HW.Host.API.Model.LogEntity;
using System.Threading.Tasks;

namespace HW.Host.API.Application.SqlLog
{
    /// <summary>
    /// Sql日志服务
    /// </summary>
    //[ApiExplorerSettings(GroupName = "HW.Host.Admin.API")]
    //[Route("api/[controller]")]
    //[ApiController]
    public class SqlLogService
    {
        private readonly ILogRepository<HW_SqlLog> _context;

        public SqlLogService(ILogRepository<HW_SqlLog> repository)
        {
            _context = repository;
        }

        /// <summary>
        /// 添加Sql执行日志
        /// </summary>
        /// <returns></returns>
        //[HttpGet("AddSqlLog")]
        public async Task AddSqlLog(string sql)
        {
            var model = new HW_SqlLog()
            {
                Sql = sql
            };
            await _context.InsertReturnLongAsync(model);
        }
    }
}