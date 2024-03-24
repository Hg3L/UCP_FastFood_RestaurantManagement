using DAL.Context;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class FoodOrderDAL
    {
        private static FoodOrderDAL _instance;
        private static readonly object _lock = new object();

        private FoodOrderDAL() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static FoodOrderDAL Instance()
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
                        _instance = new FoodOrderDAL();
                    }
                }
            }
            return _instance;
        }

        public void AddNewFoodOrder(FoodOrder foodOrder)
        {
            using (var context = new DatabaseContext())
            {
                context.FoodOrder.Add(foodOrder);
                context.SaveChanges();
            }
        }

        public List<FoodOrder> GetAllFoodOrdersByID(int id)
        {
            using (var context = new DatabaseContext())
            {
                return context.FoodOrder.Where(p => p.Id_Bill == id).
                    Include(p => p.Food).ToList();
            }
        }
    }
}
