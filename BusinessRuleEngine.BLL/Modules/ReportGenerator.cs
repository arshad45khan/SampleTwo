using BusinessRuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.BLL
{
    public class ReportGenerator : IActivityAfterPaymentProcess, IReportGenerator
    {
        public bool IsPaymentDone { get; set; }

        public bool ActivityAfterPayment(dynamic action)
        {
            if(IsPaymentDone && action == ReportAction.ShippingReport)
            {
                return GenerateShippingReport();
            }
            else if (IsPaymentDone && action == ReportAction.PackingReport)
            {
                return GeneratePackingReport();
            }
            else if (IsPaymentDone && action == ReportAction.DuplicatePackingReport)
            {
                return GeneratePackingReport();
            }
            else if (IsPaymentDone && action == ReportAction.InventoryReport)
            {
                return GenerateInventoryReport();
            }
            else
                return false;
        }

        public bool GenerateInventoryReport()
        {
            return true;
        }

        public bool GeneratePackingReport()
        {
            return true;
        }

        public bool GenerateShippingReport()
        {
            return true;
        }
    }
}
