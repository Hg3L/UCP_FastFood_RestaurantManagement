using DAL;
using DTO;

namespace BLL
{
    public class StatisticBLL
    {
        private static StatisticBLL _instance;
        private static readonly object _lock = new object();

        private StatisticBLL() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static StatisticBLL Instance()
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
                        _instance = new StatisticBLL();
                    }
                }
            }
            return _instance;
        }

        public void AddIncome(Statistic statistic)
        {
            StatisticDAL.Instance().AddNewIncome(statistic);
        }

        public decimal SelectYesterdayIncome(DateTime date)
        {
            decimal result = StatisticDAL.Instance().GetYesterdayIncome(date.AddDays(-1));
            if (result == null)
            {
                return 0;
            }
            return result;
        }

        public decimal SelectTodayIncome(DateTime date)
        {
            decimal result = StatisticDAL.Instance().GetTodayIncome(date);
            if (result == null)
            {
                return 0;
            }
            return result;
        }

        public decimal SelectTotalIncome()
        {
            decimal result = StatisticDAL.Instance().GetTotalIncome();
            if (result == null)
            {
                return 0;
            }
            return result;
        }

        public void DeleteAllStatistic()
        {
            StatisticDAL.Instance().RemoveAllStatistic();
        }

        public Dictionary<int, decimal> SelectIncomeByMonth(int year)
        {
            return StatisticDAL.Instance().GetIncomeByMonth(year);
        }

        public Dictionary<string, int> SelectTopSelling(int n)
        {
            return StatisticDAL.Instance().GetTopSellingFood(n);
        }
    }
}
