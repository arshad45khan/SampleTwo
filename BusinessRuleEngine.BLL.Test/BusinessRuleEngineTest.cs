using System;
using BusinessRuleEngine.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRuleEngine.BLL.Test
{
    [TestClass]
    public class BusinessRuleEngineTest
    {
        [TestMethod]
        public void TestGeneratePackingReport()
        {
            var module = Modules.LoadModule(Module.ReportGenerator);
            module.IsPaymentDone = true;
            var result = module.ActivityAfterPayment(ReportAction.PackingReport);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestGenerateDuplicatePackingReport()
        {
            var module = Modules.LoadModule(Module.ReportGenerator);
            module.IsPaymentDone = true;
            var result = module.ActivityAfterPayment(ReportAction.DuplicatePackingReport);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestAddnewMemberShip()
        {
            var module = Modules.LoadModule(Module.MemeberShipActivity);
            module.IsPaymentDone = true;
            var result = module.ActivityAfterPayment(MemberShipAction.SubscribeforMemberShip);
            var sendingemail = module.ActivityAfterPayment(MemberShipAction.SendingEmailforNewuser);
            Assert.IsTrue(result);
            Assert.IsTrue(sendingemail);
        }

        [TestMethod]
        public void TestUpdateMemberShip()
        {
            var module = Modules.LoadModule(Module.MemeberShipActivity);
            module.IsPaymentDone = true;
            var result = module.ActivityAfterPayment(MemberShipAction.UpdatedMemberShip);
            var sendingemail = module.ActivityAfterPayment(MemberShipAction.SendingEmailforUpgrade);
            Assert.IsTrue(result);
            Assert.IsTrue(sendingemail);
        }
    }
}
