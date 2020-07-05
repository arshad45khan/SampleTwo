using BusinessRuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.BLL
{
    public class ProductShipping : IActivityAfterPaymentProcess, IShipment
    {
        public bool IsPaymentDone { get; set ; }

        public bool ActivityAfterPayment(dynamic action)
        {
            if (IsPaymentDone && action == ShipmentAction.ShipingforOrder)
            {
                return ShippingforOrder();
            }
            else
                return false;
        }

        public bool ShippingforOrder()
        {
            return true;
        }
    }
}
