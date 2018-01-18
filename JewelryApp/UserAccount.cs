using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryApp
{
    public enum TypeOfAccount
    {
        user,
        guest
    }
    public class UserAccount
    {
        

        #region Properties
        [Key]
        public int UserId { get; private set; }
        public string UserName { get; set; }
        [StringLength(50,ErrorMessage ="Email Id should be of length 50 characters.")]
        public string UserEmailId { get; set; }
        public string Password { get; set; }
        public string LoginStatus { get; set; }
        public TypeOfAccount AccountType{ get; set; }
        #endregion

        #region Constructor
        public UserAccount()
        {
            
        }
        #endregion

    }
}

