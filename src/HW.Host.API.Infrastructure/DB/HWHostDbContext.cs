using HW.Host.API.Infrastructure.AppConfigurtaion;
using HW.Host.API.Model.DefaultEntity;
using HW.Host.API.Model.ModelEntity;
using Microsoft.EntityFrameworkCore;
using System;

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
                        Id = i,
                        BGUrl = obsUrl + "/assets/images/backGround/bg" + i + ".jpg"
                    });
            }

            modelBuilder.Entity<HW_PhoneModelInfo>().HasData(
                new HW_PhoneModelInfo { Id = 1, PhoneName = "VIVO X23", PhoneRAM = "8+128", PhonePrice = 1000, PhoneFineness = "95", PhoneColour = "红", PhoneCode = "862754045574919", PhoneLeaseTime = DateTime.Parse("2020-11-29") },
                new HW_PhoneModelInfo { Id = 2, PhoneName = "华为畅享Z 5G", PhoneRAM = "6+64", PhonePrice = 1250, PhoneFineness = "靓", PhoneColour = "黑", PhoneCode = "860450040094555", PhoneLeaseTime = DateTime.Parse("2020-11-29") },
                new HW_PhoneModelInfo { Id = 3, PhoneName = "华为畅享20Pro 5G", PhoneRAM = "6+128", PhonePrice = 1600, PhoneFineness = "靓", PhoneColour = "蓝", PhoneCode = "861189053704549", PhoneLeaseTime = DateTime.Parse("2020-11-29") },
                new HW_PhoneModelInfo { Id = 4, PhoneName = "华为Mate10 Pro", PhoneRAM = "6+64", PhonePrice = 1000, PhoneFineness = "靓", PhoneColour = "粉", PhoneCode = "866216030724606", PhoneLeaseTime = DateTime.Parse("2020-11-29") },
                new HW_PhoneModelInfo { Id = 5, PhoneName = "华为Mate10 Pro", PhoneRAM = "6+128", PhonePrice = 950, PhoneFineness = "9", PhoneColour = "黑", PhoneCode = "868034039428685", PhoneLeaseTime = DateTime.Parse("2020-11-29") },
                new HW_PhoneModelInfo { Id = 6, PhoneName = "华为Mate20", PhoneRAM = "6+64", PhonePrice = 1200, PhoneFineness = "9", PhoneColour = "蓝", PhoneCode = "865043042963151", PhoneLeaseTime = DateTime.Parse("2020-11-29") },
                new HW_PhoneModelInfo { Id = 7, PhoneName = "华为P20Pro", PhoneRAM = "6+64", PhonePrice = 1050, PhoneFineness = "95", PhoneColour = "黑", PhoneCode = "868577030922627", PhoneLeaseTime = DateTime.Parse("2020-11-29") },
                new HW_PhoneModelInfo { Id = 8, PhoneName = "华为Nova5i", PhoneRAM = "8+128", PhonePrice = 1200, PhoneFineness = "95", PhoneColour = "蓝", PhoneCode = "864928040295179", PhoneLeaseTime = DateTime.Parse("2020-11-29") },
                new HW_PhoneModelInfo { Id = 9, PhoneName = "华为P30", PhoneRAM = "8+64", PhonePrice = 1800, PhoneFineness = "靓", PhoneColour = "黑", PhoneCode = "862474042226765", PhoneLeaseTime = DateTime.Parse("2020-11-29") },
                new HW_PhoneModelInfo { Id = 10, PhoneName = "华为Nova7SE5G", PhoneRAM = "8+128", PhonePrice = 2100, PhoneFineness = "靓", PhoneColour = "黑", PhoneCode = "860133058133412", PhoneLeaseTime = DateTime.Parse("2020-11-29") },
                new HW_PhoneModelInfo { Id = 11, PhoneName = "华为P20", PhoneRAM = "6+128", PhonePrice = 1100, PhoneFineness = "靓", PhoneColour = "粉", PhoneCode = "861594045284619", PhoneLeaseTime = DateTime.Parse("2020-11-29") },
                new HW_PhoneModelInfo { Id = 12, PhoneName = "小米9", PhoneRAM = "8+128", PhonePrice = 1500, PhoneFineness = "95", PhoneColour = "黑", PhoneCode = "99001343870346", PhoneLeaseTime = DateTime.Parse("2020-11-29") },
                new HW_PhoneModelInfo { Id = 13, PhoneName = "小米9", PhoneRAM = "6+128", PhonePrice = 1150, PhoneFineness = "9", PhoneColour = "蓝", PhoneCode = "99001332374714", PhoneLeaseTime = DateTime.Parse("2020-11-29") },
                new HW_PhoneModelInfo { Id = 14, PhoneName = "小米10青春版", PhoneRAM = "8+128", PhonePrice = 1700, PhoneFineness = "靓", PhoneColour = "白", PhoneCode = "99001583306158", PhoneLeaseTime = DateTime.Parse("2020-11-29") },
                new HW_PhoneModelInfo { Id = 15, PhoneName = "红米K20Pro", PhoneRAM = "8+128", PhonePrice = 1450, PhoneFineness = "靓", PhoneColour = "白", PhoneCode = "99001302146726", PhoneLeaseTime = DateTime.Parse("2020-11-29") });
        }

        public DbSet<HW_Admin> HW_Admin { get; set; }

        public DbSet<HW_Users> HW_Users { get; set; }

        public DbSet<HW_CopywritingInfo> HW_CopywritingInfo { get; set; }

        public DbSet<HW_EmailHistoryInfo> HW_EmailHistoryInfo { get; set; }

        public DbSet<HW_BackGroundImageInfo> HW_BackGroundImageInfo { get; set; }

        public DbSet<HW_PhoneModelInfo> HW_PhoneModelInfo { get; set; }

        public DbSet<HW_PhoneReceiveInfo> HW_PhoneReceiveInfo { get; set; }

        public DbSet<HW_ReportMealInfo> HW_ReportMealInfo { get; set; }
    }
}