using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneClassLib;
using static MobilePhoneClassLib.SMSProvider;

namespace MobilePhoneTests {
    [TestClass]
    public class SMSEventTest {
        private string Result;
        private bool eventRaised = false;
        [TestMethod]
        public void SMSEventRaisedTest() {
            SMSProvider sMSProv = new SMSProvider();
            sMSProv.SMSRecieved += new SMSRecievedHandler(FakeShowSMS);
            string msg = "Test message";
            string format = "None";
            sMSProv.SendSMS(msg, format);
            Assert.IsTrue(eventRaised);
        }
        private void FakeShowSMS(string msg) {
            Result = msg;
            eventRaised = true;
        }
    }
}
