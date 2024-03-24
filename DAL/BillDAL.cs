using DAL.Context;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BillDAL
    {
        private static BillDAL _instance;
        private static readonly object _lock = new object();

        private BillDAL() { }

        // Phương thức static để truy cập vào thể hiện duy nhất của lớp
        public static BillDAL Instance()
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
                        _instance = new BillDAL();
                    }
                }
            }
            return _instance;
        }

        public void AddNewBill(Bill bill)
        {
            using (var context = new DatabaseContext())
            {
                context.Bill.Add(bill);
                context.SaveChanges();
            }
        }

        public List<Bill> GetAllBills()
        {
            using (var context = new DatabaseContext())
            {
                return context.Bill.Include(p => p.Voucher).
                    Include(p => p.Account).ToList();
            }
        }

        public void RemoveBill(int id)
        {
            using (var context = new DatabaseContext())
            {
                var foodOrder = context.FoodOrder.
                    Where(p => p.Id_Bill == id).ToList();

                foreach(var food in foodOrder)
                {
                    context.Remove(food);
                }

                var bill = context.Bill.
                    Where(p => p.Id_Bill == id).SingleOrDefault();
                context.Remove(bill);
                context.SaveChanges();
            }
        }
    }
}
