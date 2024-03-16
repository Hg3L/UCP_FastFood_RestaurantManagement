using BLL.Common;
using BLL.Helpers;
using DAL;
using DTO;

namespace BLL
{
    public class FoodBLL
    {
        private static FoodBLL _instance;
        private static readonly object _lock = new object();

        private FoodBLL() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static FoodBLL Instance()
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
                        _instance = new FoodBLL();
                    }
                }
            }
            // Trả về thể hiện duy nhất của lớp
            return _instance;
        }

        public dynamic SelectFoodList()
        {
            return FoodDAL.Instance().GetFoodList();
        }

        public List<Food> SelectAllFoodList()
        {
            return FoodDAL.Instance().GetAllFoodList();
        }

        public dynamic SelectFoodSizeByID(int id)
        {
            return FoodDAL.Instance().GetFoodSizeListByID(id);
        }

        public Food? AddingFood(string nameFood, string categoryName, string imageLocation)
        {
            var model = new Food()
            {
                Name_Food = nameFood,
                Id_Category = CategoryDAL.Instance().GetCategoryByName(categoryName),
                Image_Location = imageLocation
            };
            try
            {
                DataValidation.Instance().ValidateData(model);
                return FoodDAL.Instance().AddNewFood(model);
            }
            catch(Exception ex)
            {
                HelperElement.Message = ex.Message;
                return null;
            }
        }

        public bool IsSuccessfulAddingFoodSize(int id, string size, string price)
        {
            if (decimal.TryParse(price, out decimal value))
            {
                if (value < 0)
                {
                    HelperElement.Message = "Mệnh giá tiền không hợp lệ";
                    return false;
                }
                var model = new FoodSize()
                {
                    Size_Name = size,
                    Price_Size = value,
                    Id_Food = id
                };
                try
                {
                    DataValidation.Instance().ValidateData(model);
                     FoodDAL.Instance().AddNewFoodSize(model);
                }
                catch (Exception ex)
                {
                    HelperElement.Message = ex.Message;
                    return false;
                }
            }
            else
            {
                HelperElement.Message = "Vui lòng nhập đúng mệnh giá tiền";
                return false;
            }
            return true;
        }

        public void DeleteFood(int id)
        {
            FoodDAL.Instance().RemoveFood(id);
        }

        public void DeleteFoodSize(int id)
        {
            FoodDAL.Instance().RemoveFoodSize(id);
        }

        public int SelectIDFoodSize(string size, string price)
        {
            return FoodDAL.Instance().GetIDFoodSize(size, Convert.ToDecimal(price));
        }

        public bool IsSuccessfulModifyingFoodSize(int id, string size, string price)
        {
            // Trả về nếu thông tin sửa bị trống
            if(string.IsNullOrWhiteSpace(size) && string.IsNullOrEmpty(price))
            {
                HelperElement.Message = "Hãy điền đủ thông tin để cập nhật dữ liệu";
                return false;
            }
            // Nếu người dùng chỉ muốn sửa kích thước
            else if (!string.IsNullOrWhiteSpace(size) && string.IsNullOrEmpty(price))
            {
                var model = new FoodSize()
                {
                    Id_Size = id,
                    Size_Name = size,
                    Price_Size = null,
                };
                FoodDAL.Instance().UpdateFoodSize(model);
            }
            else if (price != null)
            {
                if (decimal.TryParse(price, out decimal value))
                {
                    if (value < 0)
                    {
                        HelperElement.Message = "Mệnh giá tiền không hợp lệ";
                        return false;
                    }
                    if (string.IsNullOrWhiteSpace(size))
                    {
                        size = null;
                    }
                    var model = new FoodSize()
                    {
                        Id_Size = id,
                        Size_Name = size,
                        Price_Size = value,
                    };
                    FoodDAL.Instance().UpdateFoodSize(model);
                    return true;
                }
                else
                {
                    HelperElement.Message = "Vui lòng nhập đúng mệnh giá tiền";
                    return false;
                }
            }
            return true;
        }

        public Food? SelectFoodByID(int id)
        {
            return FoodDAL.Instance().GetFoodByID(id);
        }

        public bool IsSuccessfulModifyingFood(int id_food, string name, int id_category, string image_location)
        {
            var model = new Food()
            {
                Id_Food = id_food,
                Name_Food = name,
                Id_Category = id_category,
                Image_Location = image_location
            };
            try
            {
                DataValidation.Instance().ValidateData(model);
                FoodDAL.Instance().UpdateFood(model);
            }
            catch (Exception ex)
            {
                HelperElement.Message = ex.Message;
                return false;
            }
            return true;
        }

        public dynamic SearchingFood(string search)
        {
            return FoodDAL.Instance().SearchingByCondition(search);
        }
    }
}
