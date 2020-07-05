using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Model
{
    public interface IShipment
    {
        bool ShippingforOrder();
    }

    public enum ShipmentAction
    {
        ShipingforOrder = 1,
    }
}
