using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneClassLib;
using SimCorp.IMS.MobilePhoneClassLib;

namespace SimCorp.IMS.MobilePhoneTests {
    [TestClass]
    public class CallSortingTest {
        [TestMethod]
        public void CallsSortTest() {
            //Arrange
            CallsStorage callStorage = new CallsStorage();
            DateTime dateTimeNow = DateTime.Now;
            List<Call> expectedResult = new List<Call>(){
                new Call("+3809703", CallType.Incoming, dateTimeNow),
                new Call("+3809701", CallType.Incoming, dateTimeNow)
            };
            //Act
            callStorage.AddCall(new Call("+3809701", CallType.Incoming, dateTimeNow));
            callStorage.AddCall(new Call("+3809703", CallType.Incoming, dateTimeNow));
            callStorage.AddCall(new Call("+3809702", CallType.Outgoing, dateTimeNow));
            callStorage.AddCall(new Call("+3809702", CallType.Incoming, dateTimeNow));
            callStorage.RemoveCallsByNumber("+3809702");
            List<Call> allCalls = callStorage.AllCalls;
            allCalls.Sort();
            List<Call> actualResult = allCalls;
            //Assert
            CollectionAssert.AreEqual(expectedResult, actualResult, new CallsComparer());
        }
    }
    public class CallsComparer : Comparer<Call> {
        public override int Compare(Call x, Call y) {
            //loop over all needed properties to compare
            int Comparison = x.PhoneNumber.CompareTo(y.PhoneNumber);
            if (Comparison != 0)
                return Comparison;
            Comparison = x.CallType.CompareTo(y.CallType);
            if (Comparison != 0)
                return Comparison;
            return x.CallTime.CompareTo(y.CallTime);
        }
    }
}
