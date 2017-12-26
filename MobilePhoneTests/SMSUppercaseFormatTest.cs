using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneClassLib;
using static MobilePhoneClassLib.SMSProvider;

namespace MobilePhoneTests {
    [TestClass]
    public class SMSUppercaseFormatTest {
        private string Result;
        [TestMethod]
        public void SMSUppercaseFormatterTest() {
            SMSProvider sMSProv = new SMSProvider();
            sMSProv.SMSRecieved += new SMSRecievedHandler(FakeShowSMS);
            string msg = "Test message";
            string format = "Uppercase";
            string expectedUppercaseResult = "TEST MESSAGE";
            sMSProv.SendSMS(msg, format);
            Assert.AreEqual(Result, expectedUppercaseResult);
        }
        private void FakeShowSMS(string msg) {
            Result = msg;
        }
    }
}
