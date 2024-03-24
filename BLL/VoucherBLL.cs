using BLL.Common;
using BLL.Helpers;
using DAL;
using DTO;

namespace BLL
{
    public class VoucherBLL
    {
        private static VoucherBLL _instance;
        private static readonly object _lock = new object();

        private VoucherBLL() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static VoucherBLL Instance()
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
                        _instance = new VoucherBLL();
                    }
                }
            }
            return _instance;
        }

        public dynamic SelectValidVouchers()
        {
            List<Voucher> listVoucher = VoucherDAL.Instance().GetAllVoucherListModel();

            // Xóa voucher hết hạn
            foreach(Voucher voucher in listVoucher)
            {
                if(voucher.End_Day.Date < DateTime.Now.Date)
                {
                    DeletingVoucher(voucher.Voucher_Code);
                    HelperElement.Message += voucher.Voucher_Code;
                }
                else
                {
                    HelperElement.Message = "";
                }
            }
            // Lọc hiển thị datagrid view bằng cách truy vấn lại
            return VoucherDAL.Instance().GetAllVoucherList();
        }

        public List<Voucher> SelectAllVoucherListModel()
        {
            return VoucherDAL.Instance().GetAllVoucherListModel();
        }

        public bool IsSuccessfulAddingVoucher(string code, string discount, string min,
            DateTime begin, DateTime end, int id_account)
        {
            if (begin > end || end.Date < DateTime.Now.Date)
            {
                HelperElement.Message = "Ngày áp dụng không hợp lệ";
                return false;
            }
            if ((decimal.TryParse(discount, out decimal discountPrice)
                && (decimal.TryParse(min, out decimal minPrice))))
            {
                var model = new Voucher()
                {
                    Voucher_Code = code,
                    Discount_Price = discountPrice,
                    Min_Price = minPrice,
                    Begin_Day = begin,
                    End_Day = end,
                    Id_Account = id_account
                };
                try
                {
                    DataValidation.Instance().ValidateData(model);
                    if (VoucherDAL.Instance().AddNewVoucher(model))
                    {
                        return true;
                    }
                    else
                    {
                        HelperElement.Message = "Voucher đã tồn tại";
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    HelperElement.Message = ex.Message;
                    return false;
                }
            }
            else
            {
                HelperElement.Message = "Vui lòng nhập mệnh giá hợp lệ !";
                return false;
            }
        }

        public void DeletingVoucher(string code)
        {
            VoucherDAL.Instance().RemoveVoucher(code);
        }

        public int SelectVoucherByCode(string code)
        {
            return VoucherDAL.Instance().GetVoucherByCode(code);
        }
    }
}
