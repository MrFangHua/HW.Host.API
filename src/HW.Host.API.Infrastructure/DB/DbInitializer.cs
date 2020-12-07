using Microsoft.EntityFrameworkCore;

namespace HW.Host.API.Infrastructure.DB
{
    public class DbInitializer
    {
        public void InitializeAsync(HWHostDbContext context)
        {
            // 根据Migrations修改/创建数据库
            context.Database.MigrateAsync();
        }
    }
}