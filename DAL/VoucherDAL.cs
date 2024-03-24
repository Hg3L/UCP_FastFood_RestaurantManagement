using DAL.Context;
using DTO;

namespace DAL
{
    public class VoucherDAL
    {
        private static VoucherDAL _instance;
        private static readonly object _lock = new object();

        private VoucherDAL() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static VoucherDAL Instance()
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
                        _instance = new VoucherDAL();
                    }
                }
            }
            return _instance;
        }

        public dynamic GetAllVoucherListModel()
        {
            using (var context = new DatabaseContext())
            {
                return context.Voucher.ToList();
            }
        }

        public dynamic GetAllVoucherList()
        {
            using(var context = new DatabaseContext())
            {
                return context.Voucher.Select(p => new
                {
                    Voucher_Code = p.Voucher_Code,
                    Name_Account = p.user.Name_Account,
                    Discount_Price = p.Discount_Price,
                    Min_Price = p.Min_Price,
                    Begin_Day = p.Begin_Day,
                    End_Day = p.End_Day
                }).ToList();
            }
        }

        public bool AddNewVoucher(Voucher voucher)
        {
            using(var context = new DatabaseContext())
            {
                try
                {
                    context.Voucher.Add(voucher);
                    context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public void RemoveVoucher(string code)
        {
            using (var context = new DatabaseContext())
            {
                var model = context.Voucher.
                    Where(p => p.Voucher_Code == code).FirstOrDefault();
                context.Voucher.Remove(model);
                context.SaveChanges();
            }
        }

        public int GetVoucherByCode(string code)
        {
            using (var context = new DatabaseContext())
            {
                var model = context.Voucher.
                    Where(p => p.Voucher_Code == code).FirstOrDefault();

                return model != null ? model.Id_Voucher : -1;
            }
        }
    }
}
