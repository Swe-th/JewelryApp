using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryApp
{
    
    static class Jewelry
    {
        private static JewelryModel db = new JewelryModel();
        
        private static List<OrderDetails> orderdetails = new List<OrderDetails>();

        public static UserAccount CreateUser(string userEmailId, string userName="Default Account", TypeOfAccount accountType=TypeOfAccount.user)
        {
            var useraccount = new UserAccount
            {
                UserEmailId = userEmailId,
                UserName = userName,
                AccountType = accountType

            };
            db.UserAccounts.Add(useraccount);
            db.SaveChanges();
            return useraccount;
        }

        #region Methods
        public static OrderDetails AddProducts(string productid,int quantity)
        {
            var orderdetail = new OrderDetails
            {

                ProductId=productid,
                Quantity = quantity,
                
            };
            orderdetails.Add(orderdetail);
            return orderdetail;

        }

        public static List<UserAccount> GetAllUserAccounts(string emailId)
        {
            return db.UserAccounts.Where(a => a.UserEmailId == emailId).ToList();
        }

        public static List<OrderDetails> GetAllOrderDetails()
        {
            return orderdetails;
        }


          public static void AddProducts(int orderId,int selecteditems)
          {
            var orderdetail=orderdetails.Where(od => od.OrderId == orderId).FirstOrDefault();
              if(orderdetail!=null)
            {
                orderdetail.AddProducts(selecteditems);
            }

          }
  
        #endregion
    }
}
