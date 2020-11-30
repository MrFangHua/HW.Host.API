using HW.Host.API.Infrastructure.AppConfigurtaion;
using HW.Host.API.Model.LogEntity;
using Microsoft.EntityFrameworkCore;

namespace HW.Host.API.Infrastructure.LogDB
{
    public class HWHostLogDbContext : DbContext
    {
        public HWHostLogDbContext(DbContextOptions<HWHostLogDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                AppConfigurtaionService.Configuration["ConnectionStrings:DefaultLog"]);
        }

        /// <summary>
        /// 数据初始化
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<HW_Log> HW_Log { get; set; }

        public DbSet<HW_SqlLog> HW_SqlLog { get; set; }
    }
}