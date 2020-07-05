
namespace BusinessRuleEngine.Model
{
    public interface IActivityAfterPaymentProcess
    {
        bool IsPaymentDone { get; set; }
        bool ActivityAfterPayment(dynamic action);
    }

    
}
