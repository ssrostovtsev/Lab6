using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhoneClassLib;
using static SimCorp.IMS.MobilePhoneClassLib.SMSProvider;

namespace MobilePhoneTests {
    [TestClass]
    public class SMSLowercaseFormatTest {
        private string Result;
        [TestMethod]
        public void SMSLowercaseFormatterTest() {
            SMSProvider sMSProv = new SMSProvider();
            sMSProv.SMSRecieved += new SMSRecievedHandler(FakeShowSMS);
            string msg = "Test message";
            string format = "Lowercase";
            string expectedLowercaseResult = "test message";
            sMSProv.SendSMS(msg, format);
            Assert.AreEqual(Result, expectedLowercaseResult);
        }
        private void FakeShowSMS(string msg) {
            Result = msg;
        }
    }
}

