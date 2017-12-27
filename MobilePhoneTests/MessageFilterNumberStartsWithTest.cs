using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneClassLib;

namespace MobilePhoneTests {
    [TestClass]
    public class MessageFilterNumberStartsWithTest {
        [TestMethod]
        public void FilterNumberStartsWithTest() {
            //Arrange
            List<Message> messages = new List<Message>();
            messages.Add(new Message("+3801", "+38 777", $"Message #1"));
            messages.Add(new Message("+3802", "+38 777", $"Message #2"));
            messages.Add(new Message("+3802", "+38 777", $"Message #3"));
            messages.Add(new Message("+3803", "+38 777", $"Message #4"));
            messages.Add(new Message("+3802", "+38 777", $"Message #5"));
            string expectedResult = "+3801";
            //Act
            MessageFilter messageFilter = new MessageFilter();
            List<Message> filteredMessages = messageFilter.NumberStartsWith(messages, "+3801");
            //Assert
            Assert.AreEqual(expectedResult, filteredMessages[0].SenderNumber);
        }

    }
}
