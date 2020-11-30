using HW.Host.API.Infrastructure.AppConfigurtaion;
using HW.Host.API.Model.DefaultEntity;
using HW.Host.API.Model.ModelEntity;
using Microsoft.EntityFrameworkCore;

namespace HW.Host.API.Infrastructure.DB
{
    public class HWHostDbContext : DbContext
    {
        public HWHostDbContext(DbContextOptions<HWHostDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                AppConfigurtaionService.Configuration["ConnectionStrings:Default"]);
        }

        /// <summary>
        /// 数据初始化
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HW_Admin>().HasData(
                new HW_Admin { Id = 1, AdminName = "Admin", AdminPwd = "Admin123456" },
                new HW_Admin { Id = 2, AdminName = "Mr.Fang", AdminPwd = "Fh2269..." });

            modelBuilder.Entity<HW_Users>().HasData(
                new HW_Users { Id = 1, UserName = "Admin", UserPwd = "Admin123456" },
                new HW_Users { Id = 2, UserName = "Mr.Fang", UserPwd = "Fh2269..." });

            modelBuilder.Entity<HW_CopywritingInfo>().HasData(
                new HW_CopywritingInfo()
                {
                    Id = 1,
                    Content = "当你的能力还撑不起你的野心的时，你就需要静下心来 好好学习。"
                },
                new HW_CopywritingInfo()
                {
                    Id = 2,
                    Content = "脏的人多了，干净反倒成了一种错。"
                },
                new HW_CopywritingInfo()
                {
                    Id = 3,
                    Content = "你羡慕的生活都是你没熬过的苦。"
                },
                new HW_CopywritingInfo()
                {
                    Id = 4,
                    Content = "所谓天才，只不过是把别人喝咖啡的功夫都用在了工作上了。"
                },
                new HW_CopywritingInfo()
                {
                    Id = 5,
                    Content = "生活便是寻求新的知识。——门捷列夫"
                },
                new HW_CopywritingInfo()
                {
                    Id = 6,
                    Content = "如果你浪费了自己的年龄，那是挺可悲的。因为你的青春只能持续一点儿时间——很短的一点儿时间。"
                },
                new HW_CopywritingInfo()
                {
                    Id = 7,
                    Content = "世界上一成不变的东西，只有“任何事物都是在不断变化的”这条真理。"
                });
            var obsUrl = AppConfigurtaionService.Configuration["ProjectInfo:ObjstorageUrl"];
            for (int i = 1; i < 101; i++)
            {
                modelBuilder.Entity<HW_BackGroundImageInfo>().HasData(
                    new HW_BackGroundImageInfo()
                    {
                        BGId = i,
                        BGUrl = obsUrl + "/assets/images/backGround/bg" + i + ".jpg"
                    });
            }
        }

        public DbSet<HW_Admin> HW_Admin { get; set; }

        public DbSet<HW_Users> HW_Users { get; set; }

        public DbSet<HW_CopywritingInfo> HW_CopywritingInfo { get; set; }

        public DbSet<HW_EmailHistoryInfo> HW_EmailHistoryInfo { get; set; }

        public DbSet<HW_BackGroundImageInfo> HW_BackGroundImageInfo { get; set; }
    }
}