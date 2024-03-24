using BLL;
using DAL.Context;
using DTO;

namespace DAL
{
    public class StatisticDAL
    {
        private static StatisticDAL _instance;
        private static readonly object _lock = new object();

        private StatisticDAL() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static StatisticDAL Instance()
        {
            // Kiểm tra xem đã có thể hiện nào được tạo chưa
            if (_instance == null)
            {
                // Đồng bộ hóa việc kiểm tra và tạo thể hiện trong môi trường đa luồng
                lock (_lock)
                {
                    // Kiểm tra lại sau khi đồng bộ hóa để tránh tạo thể hiện trùng lặp
                    if (_instance == null)
                    {
                        _instance = new StatisticDAL();
                    }
                }
            }
            return _instance;
        }

        public void AddNewIncome(Statistic statistic)
        {
            using (var context = new DatabaseContext())
            {
                context.Statistic.Add(statistic);
                context.SaveChanges();
            }
        }

        public decimal GetYesterdayIncome(DateTime date)
        {
            using (var context = new DatabaseContext())
            {
                return context.Statistic.
                    Where(p => p.Income_Date.DayOfYear == date.DayOfYear).
                    Sum(p => p.Total_Income);
            }
        }

        public decimal GetTodayIncome(DateTime date)
        {
            using (var context = new DatabaseContext())
            {
                return context.Statistic.
                    Where(p => p.Income_Date.DayOfYear == date.DayOfYear).
                    Sum(p => p.Total_Income);
            }
        }

        public decimal GetTotalIncome()
        {
            using (var context = new DatabaseContext())
            {
                return context.Statistic.
                    Sum(p => p.Total_Income);
            }
        }

        public void RemoveAllStatistic()
        {
            using (var context = new DatabaseContext())
            {
                foreach(var statistic in context.Statistic)
                {
                    context.Remove(statistic);
                }
                context.SaveChanges();
            }
        }

        public Dictionary<int, decimal> GetIncomeByMonth(int year)
        {
            using (var context = new DatabaseContext())
            {
                // Khởi tạo từ điển với tất cả các tháng có thu nhập mặc định là 0
                var incomeByMonth = Enumerable.Range(1, 12)
                    .ToDictionary(month => month, month => 0m);

                var incomeData = context.Statistic
                    .Where(p => p.Income_Date.Year == year)
                    .GroupBy(p => p.Income_Date.Month)
                    .Select(g => new { Month = g.Key, TotalIncome = g.Sum(p => p.Total_Income) });

                foreach (var data in incomeData)
                {
                    incomeByMonth[data.Month] = data.TotalIncome;
                }

                return incomeByMonth;
            }
        }

        public Dictionary<string, int> GetTopSellingFood(int n)
        {
            using (var context = new DatabaseContext())
            {
                var topSellingFoods = context.FoodOrder
                    .GroupBy(order => order.Food.Name_Food)
                    .Select(group => new
                    {
                        FoodName = group.Key,
                        TotalCount = group.Sum(order => order.Count_Food)
                    })
                    .OrderByDescending(result => result.TotalCount)
                    .Take(n)
                    .ToDictionary(result => result.FoodName, result => result.TotalCount);

                return topSellingFoods;
            }
        }

        public int GetCountCategory()
        {
            using (var context = new DatabaseContext())
            {
                int count = context.Category.Count();
                if (count == null)
                {
                    return 0;
                }
                return count;
            }
        }

        public int GetCountFood()
        {
            using (var context = new DatabaseContext())
            {
                int count = context.Food.Count();
                if (count == null)
                {
                    return 0;
                }
                return count;
            }
        }

        public int GetCountEmployee()
        {
            using (var context = new DatabaseContext())
            {
                int count = context.UserAccount.
                    Where(p => p.Type_Account == "Nhân viên").
                    Count();
                if (count == null)
                {
                    return 0;
                }
                return count;
            }
        }
    }
}
