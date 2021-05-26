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
        public static ObservableCollection<Payments> getPayments()
        {
            var paymentlist = new ObservableCollection<Payments>();
            using (var _dbContext = new DBConnector())
            {
                _dbContext.Payments.ToList().ForEach(c => paymentlist.Add(c));
            }
            return paymentlist;
        }

        public static ObservableCollection<Categories> getCategories()
        {
            var categorylist = new ObservableCollection<Categories>();
            using (var _dbContext = new DBConnector())
            {
                _dbContext.Categories.ToList().ForEach(c => categorylist.Add(c));
            }
            return categorylist;
        }

        public static void AddCategory(Categories categories)
        {
            using (var _dbContext = new DBConnector())
            {
                _dbContext.Categories.Add(categories);
                _dbContext.SaveChanges();
            }
        }

        public static void AddPayment(Payments newpayment)
        {
            using (var _dbContext = new DBConnector())
            {
                _dbContext.Payments.Add(newpayment);
                _dbContext.SaveChanges();
            }
        }

        public static void delete(Categories tempCategory)
        {
            using (var _DBContext = new DBConnector())
            {
                    _DBContext.Categories.Remove(_DBContext.Categories.FirstOrDefault(p => tempCategory.Id == p.Id));
                    _DBContext.SaveChanges();
            }
        }
    }
}
