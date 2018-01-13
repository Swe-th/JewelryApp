using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryApp
{
    class Orders
    {
        #region Properties
        public int OrderId { get; set; }
        public string DateCreated { get; set; }
        public string DateShipped { get; set; }
        public string CustomerName { get; set; }
        public string CustomerId { get; set; }
        public string Status { get; set; }
        public string ShippingId { get; set; }
        #endregion
    }
}