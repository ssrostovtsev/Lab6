using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneClassLib;

namespace MobilePhoneTests {
    [TestClass]
    public class MessageFilterOrAllFiltersTest {
        [TestMethod]
        public void FilterOrAllFiltersTest() {
            //Arrange
            List<Message> messages = new List<Message>();
            messages.Add(new Message("+3801", "+38 777", $"Message #1"));
            messages.Add(new Message("+3802", "+38 777", $"Message #2"));
            messages.Add(new Message("+3802", "+38 777", $"Message #22"));
            messages.Add(new Message("+3803", "+38 777", $"Message #4"));
            messages.Add(new Message("+3802", "+38 777", $"Message #5"));
            List<Message> expectedResult = new List<Message>();
            expectedResult.Add(new Message("+3802", "+38 777", $"Message #2"));
            expectedResult.Add(new Message("+3802", "+38 777", $"Message #22"));
            expectedResult.Add(new Message("+3803", "+38 777", $"Message #5"));
            expectedResult.Add(new Message("+3802", "+38 777", $"Message #4"));
            //Act
            MessageFilter messageFilter = new MessageFilter();
            List<Message> filteredMessages = messageFilter.OrAllFilters(messages, "+3802","#4",new DateTime(2017,1,1), new DateTime(2017, 1, 1));
            //Assert
            for (int i = 0; i < 4; i++) {
                Assert.AreEqual(expectedResult[i].Text, filteredMessages[i].Text);
            }
        }
    }
}
