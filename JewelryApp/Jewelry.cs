using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryApp
{
    
    static class Jewelry
    {
        private static List<UserAccount> useraccounts = new List<UserAccount>();
        private static List<OrderDetails> orderdetails = new List<OrderDetails>();

        public static UserAccount CreateUser(string userEmailId, string userName="Default Account", TypeOfAccount accountType=TypeOfAccount.user)
        {
            var useraccount = new UserAccount
            {
                UserEmailId = userEmailId,
                UserName = userName,
                AccountType = accountType

            };
            useraccounts.Add(useraccount);
            return useraccount;
        }

        #region Methods
        public static OrderDetails AddProducts(string productname,int quantity)
        {
            var orderdetail = new OrderDetails
            {

                ProductName=productname,
                Quantity = quantity,
                
            };
            orderdetails.Add(orderdetail);
            return orderdetail;

        }

        public static List<UserAccount> GetAllUserAccounts()
        {
            return useraccounts;
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
