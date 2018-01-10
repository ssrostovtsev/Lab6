using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneClassLib;
using SimCorp.IMS.MobilePhoneClassLib;

namespace SimCorp.IMS.MobilePhoneTests {
    [TestClass]
    public class CallEqualityTest {
        [TestMethod]
        public void CallEqualNumberTest() {
            //Arrange
            CallsStorage callStorage = new CallsStorage();
            DateTime dateTimeNow = DateTime.Now;
            Call callFirst = new Call("+38097 01", CallType.Incoming, dateTimeNow);
            Call callSecond = new Call("+38097 01", CallType.Incoming, dateTimeNow);
            bool expectedResult = true;
            bool actualResult;
            //Act
            actualResult = callFirst.Equals(callSecond);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CallNotEqualTypeTest() {
            //Arrange
            CallsStorage callStorage = new CallsStorage();
            DateTime dateTimeNow = DateTime.Now;
            Call callFirst = new Call("+38097 01", CallType.Incoming, dateTimeNow);
            Call callSecond = new Call("+38097 01", CallType.Outgoing, dateTimeNow);
            bool expectedResult = false;
            bool actualResult;
            //Act
            actualResult = callFirst.Equals(callSecond);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CallNotEqualTimeTest() {
            //Arrange
            CallsStorage callStorage = new CallsStorage();
            DateTime dateTimeNow = DateTime.Now;
            Call callFirst = new Call("+38097 01", CallType.Incoming, dateTimeNow);
            Call callSecond = new Call("+38097 01", CallType.Incoming, dateTimeNow.AddHours(1));
            bool expectedResult = true;
            bool actualResult;
            //Act
            actualResult = callFirst.Equals(callSecond);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
