using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneClassLib;
using static MobilePhoneClassLib.SMSProvider;

namespace MobilePhoneTests {
    [TestClass]
    public class SMSNoneFormatTest {
        private string Result;
        [TestMethod]
        public void SMSNoneFormatterTest() {
            SMSProvider sMSProv = new SMSProvider();
            sMSProv.SMSRecieved += new SMSRecievedHandler(FakeShowSMS);
            string msg = "Test message";
            string format = "None";
            string expectedNoneResult = "Test message";
            sMSProv.SendSMS(msg, format);
            Assert.AreEqual(Result, expectedNoneResult);
        }
        private void FakeShowSMS(string msg) {
            Result = msg;
        }
    }
}
