using BLL.Common;
using BLL.Helpers;
using DAL;
using DTO;

namespace BLL
{
    public class CategoryBLL
    {
        private static CategoryBLL _instance;
        private static readonly object _lock = new object();

        private CategoryBLL() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static CategoryBLL Instance()
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
                        _instance = new CategoryBLL();
                    }
                }
            }
            // Trả về thể hiện duy nhất của lớp
            return _instance;
        }

        public List<Category> SelectAllFoodCategoryList()
        {
            return CategoryDAL.Instance().GetFoodCategoryList();
        }

        public dynamic SelectIdAndCategoryName()
        {
            return CategoryDAL.Instance().GetListIdAndCategoryName();
        }

        public bool IsSuccessfulAddingCategory(string name, string image_location)
        {
            Category category = new Category()
            {
                Name_Category = name,
                Image_Location = image_location
            };
            try
            {
                DataValidation.Instance().ValidateData(category);
                CategoryDAL.Instance().AddNewCategory(category);
            }
            catch(Exception ex)
            {
                HelperElement.Message = ex.Message;
                return false;
            }
            return true;
        }

        public bool IsSuccessfulModifyingCategory(int id , string name, string image_location)
        {
            Category category = new Category()
            {
                Id_Category = id,
                Name_Category = name,
                Image_Location = image_location
            };
            try
            {
                DataValidation.Instance().ValidateData(category);
                CategoryDAL.Instance().UpdateCategory(category);
            }
            catch (Exception ex)
            {
                HelperElement.Message = ex.Message;
                return false;
            }
            return true;
        }

        public void DeleteCategory(int id)
        {
            CategoryDAL.Instance().RemoveCategory(id);
        }

        public Category? GetCategory(int id)
        {
            return CategoryDAL.Instance().GetCategoryByID(id);
        }

        public dynamic SearchingCategory(string searchingText)
        {
            return CategoryDAL.Instance().SearchingByCondition(searchingText);
        }
    }
}
