using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Model
{
    public interface IReportGenerator
    {
        bool GenerateInventoryReport();
        bool GeneratePackingReport();
        bool GenerateShippingReport();
    }

    public enum ReportAction
    {
        InventoryReport = 1,
        PackingReport = 2,
        DuplicatePackingReport = 3,
        ShippingReport  = 4,
    }
}
