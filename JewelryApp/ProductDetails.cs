using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryApp
{
    class ProductDetails
    {
        #region Properties
        public string ProductId { get; private set; }
        public string ProductName { get; private set; }
        public float ProductPrice { get; private set; }
        public decimal ProductWeight { get; private set; }
        public string ProductDescription { get; private set; }
        public string ProductImage { get; private set; }
        #endregion


    }
}
