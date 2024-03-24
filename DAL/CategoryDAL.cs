using DAL.Context;
using DTO;

namespace DAL
{
    public class CategoryDAL
    {
        private static CategoryDAL _instance;
        private static readonly object _lock = new object();

        private CategoryDAL() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static CategoryDAL Instance()
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
                        _instance = new CategoryDAL();
                    }
                }
            }
            return _instance;
        }

        public List<Category> GetFoodCategoryList()
        {
            using(var context = new DatabaseContext())
            {
                return context.Category.ToList();
            }
        }

        // Lấy danh sách danh mục theo id và tên
        public dynamic GetListIdAndCategoryName()
        {
            using (var context = new DatabaseContext())
            {
                return context.Category
                             .Select(p => new {
                                 Id_Category = p.Id_Category,
                                 Name_Category = p.Name_Category })
                             .ToList();
            }
        }

        // Thêm danh mục
        public void AddNewCategory(Category category)
        {
            using (var context = new DatabaseContext())
            {
                context.Category.Add(category);
                context.SaveChanges();
            }
        }

        // Sửa danh mục
        public void UpdateCategory(Category category)
        {
            using (var context = new DatabaseContext())
            {
                var model = context.Category.
                    Where(p => p.Id_Category == category.Id_Category).FirstOrDefault();
                model.Name_Category = category.Name_Category;
                model.Image_Location = category.Image_Location;
                context.SaveChanges();
            }
        }

        // Xóa danh mục
        public void RemoveCategory(int id)
        {
            using (var context = new DatabaseContext())
            {
                var model = context.Category.
                    Where(p => p.Id_Category == id).FirstOrDefault();
                context.Remove(model);
                context.SaveChanges();
            }
        }

        // Lấy ra 1 danh mục theo id
        public Category? GetCategoryByID(int id)
        {
            using (var context = new DatabaseContext())
            {
                return context.Category.
                    Where(p => p.Id_Category == id).FirstOrDefault();
            }
        }

        public dynamic SearchingByCondition(string searchingText)
        {
            using (var context = new DatabaseContext())
            {
                if(int.TryParse(searchingText, out int id))
                {
                    return context.Category.
                    Where(p => p.Id_Category == int.Parse(searchingText)).ToList();
                }
                else
                {
                    return context.Category.
                   Where(p => p.Name_Category.Contains(searchingText)).ToList();
                }
            }
        }

        public dynamic GetCategoryByName(string nameCategory)
        {
            using (var context = new DatabaseContext())
            {
                var model = context.Category.
                    Where(p => p.Name_Category == nameCategory).FirstOrDefault();
                if (model == null)
                {
                    return null;
                }
                return model.Id_Category;
            }
        }
    }
}
