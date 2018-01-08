using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhoneClassLib;

namespace SimCorp.IMS.MobilePhoneTests {
    [TestClass]
    public class MessageFilterAndAllFiltersTest {
        [TestMethod]
        public void FilterAndAllFiltersTest() {
            //Arrange
            List<Message> messages = new List<Message>();
            messages.Add(new Message("+3801", "+38 777", $"Message #1"));
            messages.Add(new Message("+3802", "+38 777", $"Message #2"));
            messages.Add(new Message("+3802", "+38 777", $"Message #22"));
            messages.Add(new Message("+3803", "+38 777", $"Message #4"));
            messages.Add(new Message("+3802", "+38 777", $"Message #5"));
            List<Message> expectedResult = new List<Message>();
            expectedResult.Add(new Message("+3802", "+38 777", $"Message #5"));
            //Act
            MessageFilter messageFilter = new MessageFilter();
            List<Message> filteredMessages = messageFilter.AndAllFilters(messages, "+3802", "#5", new DateTime(2017, 1, 1), new DateTime(2099, 1, 1));
            //Assert
            Assert.AreEqual(expectedResult[0].Text, filteredMessages[0].Text);
        }
    }
}
