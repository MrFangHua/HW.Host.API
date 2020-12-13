namespace HW.Host.API.Application.ReportMealInfo.Dto
{
    /// <summary>
    /// 报餐
    /// </summary>
    public class ReportMeal
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 报餐员工Id
        /// </summary>
        public int ReportMealUserId { get; set; }

        /// <summary>
        /// 报餐员工Name
        /// </summary>
        public string ReportMealUserName { get; set; }

        /// <summary>
        /// 报餐时间（年-月-日/1900-1-1）不带0的日期时间
        /// </summary>
        public string ReportMealTime { get; set; }

        /// <summary>
        /// 中餐
        /// </summary>
        public int Lunch { get; set; } = 0;

        /// <summary>
        /// 晚餐
        /// </summary>
        public int Dinner { get; set; } = 0;

        /// <summary>
        ///餐详情
        /// </summary>
        private string meal;

        /// <summary>
        /// 餐详情
        /// </summary>
        public string Meal
        {
            get { return meal; }
            set
            {
                if (Lunch == 1 && Dinner == 1)
                {
                    meal = "中餐 晚餐";
                }
                else if (Lunch == 1 && Dinner == 0)
                {
                    meal = "中餐";
                }
                else if (Lunch == 0 && Dinner == 1)
                {
                    meal = "晚餐";
                }
            }
        }
    }
}