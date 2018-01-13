using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryApp
{
    enum TypeOfAccount
    {
        user,
        guest
    }
    class UserAccount
    {
        #region static
        private static int lastUserId = 0;
        #endregion

        #region Properties
        public int UserId { get; private set; }
        public string UserName { get; set; }
        public string UserEmailId { get; set; }
        public string Password { get; set; }
        public string LoginStatus { get; set; }
        public TypeOfAccount AccountType{ get; set; }
        #endregion

        #region Constructor
        public UserAccount()
        {
            UserId = ++lastUserId;
        }
        #endregion

    }
}

