using Microsoft.EntityFrameworkCore;

namespace HW.Host.API.Infrastructure.LogDB
{
    public class LogDbInitializer
    {
        public void InitializeAsync(HWHostLogDbContext context)
        {
            // 根据Migrations修改/创建数据库
            context.Database.MigrateAsync();
        }
    }
}