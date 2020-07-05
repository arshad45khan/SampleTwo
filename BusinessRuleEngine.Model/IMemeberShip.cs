using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Model
{
    public interface IMemeberShip
    {
        bool ActiavateMemberShip();
        bool UpgradeMemberShip();
        bool SendConfirmationEmail(MemberShipAction action);
    }

    public enum MemberShipAction
    {
        SubscribeforMemberShip = 1,
        UpdatedMemberShip = 2,
        SendingEmailforNewuser = 3,
        SendingEmailforUpgrade = 4,
    }
}
