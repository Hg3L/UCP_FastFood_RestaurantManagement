using DAL.Context;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class FoodDAL
    {
        private static FoodDAL _instance;
        private static readonly object _lock = new object();

        private FoodDAL() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static FoodDAL Instance()
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
                        // Tạo một thể hiện mới của lớp SendingEmailOTP
                        _instance = new FoodDAL();
                    }
                }
            }
            // Trả về thể hiện duy nhất của lớp
            return _instance;
        }

        public dynamic GetFoodList()
        {
            using(var context = new DatabaseContext())
            {
                return context.Food.
                    Select(p => new
                    {
                        Id_Food = p.Id_Food,
                        Name_Food = p.Name_Food,
                        Type_Food = p.Category.Name_Category
                    }).ToList();
            }
        }

        public List<Food> GetAllFoodList()
        {
            using (var context = new DatabaseContext())
            {
                return context.Food.
                    Include(p => p.FoodSizes).ToList();
            }
        }

        public dynamic GetFoodSizeListByID(int id)
        {
            using (var context = new DatabaseContext())
            {
                return context.FoodSize.
                    Where(p => p.Id_Food == id).
                    Select(p => new
                    {
                        FoodSize = p.Size_Name,
                        FoodPrice = p.Price_Size
                    }).ToList();
            }
        }

        public Food AddNewFood(Food food)
        {
            using (var context = new DatabaseContext())
            {
                context.Food.Add(food);
                context.SaveChanges();
            }
            return food;
        }

        public void AddNewFoodSize(FoodSize food)
        {
            using (var context = new DatabaseContext())
            {
                context.FoodSize.Add(food);
                context.SaveChanges();
            }
        }

        public void RemoveFood(int id)
        {
            using(var context = new DatabaseContext())
            {
                // Xóa kích cỡ món tại bảng FoodSize
                var listFoodSize = context.FoodSize.
                    Where(p => p.Id_Food == id).ToList();
                if(listFoodSize != null)
                {
                    foreach(var foodSize in listFoodSize)
                    {
                        context.Remove(foodSize);
                    }
                }
                var model = context.Food.
                    Where(p => p.Id_Food == id).FirstOrDefault();
                context.Remove(model);
                context.SaveChanges();
            }
        }

        public void RemoveFoodSize(int id)
        {
            using (var context = new DatabaseContext())
            {
                // Xóa kích cỡ món tại bảng FoodSize
                var model = context.FoodSize.
                    Where(p => p.Id_Size == id).FirstOrDefault();
                context.Remove(model);
                context.SaveChanges();
            }
        }

        public int GetIDFoodSize(string size, decimal price)
        {
            using (var context = new DatabaseContext())
            {
                 var model = context.FoodSize.
                    Where(p => p.Size_Name == size
                    && p.Price_Size == price).FirstOrDefault();
                return model.Id_Size;
            }
        }

        public void UpdateFoodSize(FoodSize foodsize)
        {
            using (var context = new DatabaseContext())
            {
                if(foodsize.Size_Name == null && foodsize.Price_Size != null)
                {
                    var model = context.FoodSize
                        .Where(p => p.Id_Size == foodsize.Id_Size).FirstOrDefault();
                    model.Price_Size = foodsize.Price_Size;
                    context.SaveChanges();
                }
                else if(foodsize.Size_Name != null && foodsize.Price_Size == null)
                {
                    var model = context.FoodSize
                        .Where(p => p.Id_Size == foodsize.Id_Size).FirstOrDefault();
                    model.Size_Name = foodsize.Size_Name;
                    context.SaveChanges();
                }
                else
                {
                    var model = context.FoodSize
                        .Where(p => p.Id_Size == foodsize.Id_Size).FirstOrDefault();
                    model.Size_Name = foodsize.Size_Name;
                    model.Price_Size = foodsize.Price_Size;
                    context.SaveChanges();
                }
            }
        }

        public Food? GetFoodByID(int id)
        {
            using (var context = new DatabaseContext())
            {
                return context.Food.
                    Where(p => p.Id_Food == id).FirstOrDefault();
            }
        }

        public void UpdateFood(Food food)
        {
            using (var context = new DatabaseContext())
            {
                var model = context.Food.Where(p => p.Id_Food == food.Id_Food).FirstOrDefault();
                model.Name_Food = food.Name_Food;
                model.Image_Location = food.Image_Location;
                model.Id_Category = food.Id_Category;
                context.SaveChanges();
            }
        }

        public dynamic SearchingByCondition(string search)
        {
            using (var context = new DatabaseContext())
            {
                if (int.TryParse(search, out int id))
                {
                    return context.Food.
                    Where(p => p.Id_Food == int.Parse(search)).
                    Select(p => new
                    {
                        Id_Food = p.Id_Food,
                        Name_Food = p.Name_Food,
                        Type_Food = p.Category.Name_Category
                    }).ToList();
                }
                else
                {
                    return context.Food.
                   Where(p => p.Name_Food.Contains(search)).
                   Select(p => new
                   {
                       Id_Food = p.Id_Food,
                       Name_Food = p.Name_Food,
                       Type_Food = p.Category.Name_Category
                   }).ToList();
                }
            }
        }
    }
}
