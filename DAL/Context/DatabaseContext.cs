using DTO;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class DatabaseContext : DbContext
    {
        // DbSet để tương tác với các bảng trong cơ sở dữ liệu.
        public DbSet<UserAccount> UserAccount { get; set; }
        public DbSet<DeviceAccount> DeviceAccount { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<FoodSize> FoodSize { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Voucher> Voucher { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<FoodOrder> FoodOrder { get; set; }
        public DbSet<Statistic> Statistic { get; set; }

        // Chuỗi kết nối để kết nối đến cơ sở dữ liệu, lấy từ cấu hình.
        private string ConnectionString = @"Data Source=HOANGLAM;
                        Initial Catalog=FastFood_RestaurantManagement;
                        Integrated Security=True;
                        Trust Server Certificate=True";

        // Phương thức ghi đè để cấu hình Entity Framework Core để sử dụng SQL Server làm cơ sở dữ liệu.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Sử dụng chuỗi kết nối để thiết lập kết nối với cơ sở dữ liệu SQL Server.
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
