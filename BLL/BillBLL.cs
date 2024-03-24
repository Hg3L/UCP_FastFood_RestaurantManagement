using BLL.Helpers;
using DTO;
using System.Security.Cryptography;

namespace BLL
{
    public class BillBLL
    {
        private static BillBLL _instance;
        private static readonly object _lock = new object();

        private BillBLL() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static BillBLL Instance()
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
                        _instance = new BillBLL();
                    }
                }
            }
            return _instance;
        }

        public void AddBill(Bill bill)
        {
            BillDAL.Instance().AddNewBill(bill);
        } 

        public List<Bill> SelectAllBills()
        {
            return BillDAL.Instance().GetAllBills();
        }

        private List<Bill>? SelectBillsByCondition(decimal from, decimal to, DateTime date, List<Bill> list)
        {
            List<Bill> filterList = new List<Bill>();
            if (from == -1 && to == -1)
            {
                foreach (Bill bill in list)
                {
                    if (bill.Date_invoice.DayOfYear == date.DayOfYear)
                    {
                        filterList.Add(bill);
                    }
                }
            }
            else if (from != -1 && to == -1)
            {
                foreach (Bill bill in list)
                {
                    if (bill.Date_invoice.DayOfYear == date.DayOfYear
                        && bill.Total_Price >= from
                        && bill.Total_Price <= list.Max(p => p.Total_Price))
                    {
                        filterList.Add(bill);
                    }
                }
            }
            else if (from == -1 && to != -1)
            {
                foreach (Bill bill in list)
                {
                    if (bill.Date_invoice.DayOfYear == date.DayOfYear
                        && bill.Total_Price >= list.Min(p => p.Total_Price)
                        && bill.Total_Price <= to)
                    {
                        filterList.Add(bill);
                    }
                }
            }
            else if(from != -1 && to != -1)
            {
                foreach (Bill bill in list)
                {
                    if (bill.Date_invoice.DayOfYear == date.DayOfYear
                        && bill.Total_Price >= from
                        && bill.Total_Price <= to)
                    {
                        filterList.Add(bill);
                    }
                }
            }
            return filterList;
        }

        public List<Bill>? FilterBills(string from, string to, DateTime date, List<Bill> list)
        {
            if (from == "" && to == "")
            {
                return SelectBillsByCondition(-1, -1, date, list);
            }
            if (from != "" && to == "")
            {
                if (!decimal.TryParse(from, out decimal price_from))
                {
                    return null;
                }
                else
                {
                    return SelectBillsByCondition(price_from, -1, date, list);
                }
            }
            if (from == "" && to != "")
            {
                if (!decimal.TryParse(to, out decimal price_to))
                {
                    return null;
                }
                else
                {
                    return SelectBillsByCondition(-1, price_to, date, list);
                }
            }
            if(from != "" && to != "")
            {
                if (!decimal.TryParse(from, out decimal price_from)
                    || !decimal.TryParse(to, out decimal price_to))
                {
                    return null;
                }
                else
                {
                    return SelectBillsByCondition(price_from, price_to, date, list);
                }
            }
            return null;
        }

        public void DeleteBill(int id)
        {
            BillDAL.Instance().RemoveBill(id);
        }
    }
}
