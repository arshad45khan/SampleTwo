using BusinessRuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.BLL
{
    public class MemeberShip : IActivityAfterPaymentProcess, IMemeberShip
    {
        public bool IsPaymentDone { get; set; }

        public bool ActivityAfterPayment(dynamic action)
        {
            if(IsPaymentDone && action == MemberShipAction.SubscribeforMemberShip)
            {
                return ActiavateMemberShip();
            }
            else if (IsPaymentDone && action == MemberShipAction.UpdatedMemberShip)
            {
                return UpgradeMemberShip();
            }
            else if (IsPaymentDone && action == MemberShipAction.SendingEmailforNewuser)
            {
                return SendConfirmationEmail(MemberShipAction.SendingEmailforNewuser);
            }
            else if (IsPaymentDone && action == MemberShipAction.SendingEmailforUpgrade)
            {
                return SendConfirmationEmail(MemberShipAction.SendingEmailforNewuser);
            }
            else
                return false;
        }

        public bool ActiavateMemberShip()
        {
            //will implement the Actiavate MemberShip logic here.
            return true;
        }

        public bool UpgradeMemberShip()
        {
            //will implement the Actiavate MemberShip logic here.
            return true;
        }

        public bool SendConfirmationEmail(MemberShipAction neworupgrade)
        {
            if (MemberShipAction.SendingEmailforNewuser == neworupgrade)
                return true;    // Implement New user upgrade email
            else
                return true; // Implement update user upgrade email
        }
    }
}
