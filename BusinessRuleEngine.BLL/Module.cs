using BusinessRuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.BLL
{
    public class Modules
    {
        public static IActivityAfterPaymentProcess LoadModule(Module module)
        {
            IActivityAfterPaymentProcess activity = null;
            switch(module)
            {
                case Module.ReportGenerator:
                    activity = Factory<IActivityAfterPaymentProcess, ReportGenerator>.CreateModule();
                    break;
                case Module.MemeberShipActivity:
                    activity = Factory<IActivityAfterPaymentProcess, MemeberShip>.CreateModule();
                    break;
                case Module.ProductShipping:
                    activity = Factory<IActivityAfterPaymentProcess, ProductShipping>.CreateModule();
                    break;
                default:
                    break;
            }
            return activity;
        }
    }
}
