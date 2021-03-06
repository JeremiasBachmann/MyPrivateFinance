using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrivateFinance
{
    public static class DBConntext
    {
        public static ObservableCollection<Payments> GetPayments()
        {
            var paymentlist = new ObservableCollection<Payments>();
            using (var _dbContext = new DBConnector())
            {
                _dbContext.Payments.ToList().ForEach(c => paymentlist.Add(c));
            }
            return paymentlist;
        }

        public static ObservableCollection<Categories> GetCategories()
        {
            var categorylist = new ObservableCollection<Categories>();
            using (var _dbContext = new DBConnector())
            {
                _dbContext.Categories.ToList().ForEach(c => categorylist.Add(c));
            }
            return categorylist;
        }

        public static void AddCategory(Categories category)
        {
            using (var _dbContext = new DBConnector())
            {
                _dbContext.Categories.Add(category);
                _dbContext.SaveChanges();
            }
        }

        public static void AddPayment(Payments payment)
        {
            using (var _dbContext = new DBConnector())
            {
                _dbContext.Payments.Add(payment);
                _dbContext.SaveChanges();
            }
        }

        public static void UpdatePayment(int paymentId, string desription, decimal amount,int categoryId,DateTime date, bool isIncome)
        {
            using (var _dbContext = new DBConnector())
            {
                Payments payment = _dbContext.Payments.FirstOrDefault(p => p.Id == (paymentId));
                payment.Description = desription;
                payment.Amount = amount;
                payment.CategoryId = categoryId;
                payment.Date = date;
                payment.IsIncome = isIncome;
                _dbContext.SaveChanges();
            }
        }

        public static void DeleteCategory(Categories category)
        {
            using (var _DBContext = new DBConnector())
            {
                    _DBContext.Categories.Remove(_DBContext.Categories.FirstOrDefault(p => category.Id == p.Id));
                    _DBContext.SaveChanges();
            }
        }


        public static void DeletePayment(Payments payment)
        {
            using (var _DBContext = new DBConnector())
            {
                _DBContext.Payments.Remove(_DBContext.Payments.FirstOrDefault(p => payment.Id == p.Id));
                _DBContext.SaveChanges();
            }
        }
    }
}
