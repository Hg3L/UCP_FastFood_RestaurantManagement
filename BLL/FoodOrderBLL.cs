using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FoodOrderBLL
    {
        private static FoodOrderBLL _instance;
        private static readonly object _lock = new object();

        private FoodOrderBLL() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static FoodOrderBLL Instance()
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
                        _instance = new FoodOrderBLL();
                    }
                }
            }
            return _instance;
        }

        public void AddFoodOrder(FoodOrder food)
        {
            FoodOrderDAL.Instance().AddNewFoodOrder(food);
        }

        public List<FoodOrder> SelectAllFoodOrdersByID(int id)
        {
            return FoodOrderDAL.Instance().GetAllFoodOrdersByID(id);
        }
    }
}
