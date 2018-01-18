using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryApp
{
    class OrderDetails
    {
        #region static
        private static int lastOrderId = 0;
        #endregion

        #region Properties
        public int OrderId { get; private set; }
        public string ProductId{ get; set; }
        public int Quantity { get; set; }
        public decimal UnitCost { get; private set; }
        
        #endregion

        #region Constructor
        public OrderDetails()
        {
           OrderId=++lastOrderId;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Add products to the cart
        /// </summary>
        /// <param name="selecteditems">No of selected products to be added to cart</param>
        public void AddProducts(int selecteditems)
        {
            Quantity += selecteditems;
        }

        ///<summary>
        ///Calculating SubTotal
        /// </summary>
        /// <param name="selecteditems">Calculates the total cost per Order</param>
        public void SubTotal()
        {
            decimal totalCost = UnitCost * Quantity;
        }
        #endregion


    }
}

