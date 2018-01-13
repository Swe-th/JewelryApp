using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryApp
{
    enum TypeOfShipping
    {
        ExpeditedShipping,
        StandardShipping,
        FreeShipping

    }
    class ShippingInformation
    {
        
        #region Properties
        public int ShippingId { get; private set; }
        public TypeOfShipping ShippingType { get; set; }
        public int ShippingCost { get; set; }
        public int ShippingRegionId { get; private set; }
        #endregion

    }
}