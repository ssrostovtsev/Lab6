using System;
using System.Collections.Generic;
using System.Linq;

namespace MobilePhoneClassLib {
    public class MessageFilter {
        public List<Message> NumberStartsWith(List<Message> messages, string senderNumber) {
            //filtered by sender number
            List<MobilePhoneClassLib.Message> filteredMessages = (from m in messages
                                                                  where m.SenderNumber.ToUpper().StartsWith(senderNumber.ToUpper())
                                                                  select m).ToList();
            return filteredMessages;
        }
        public List<Message> TextContains(List<Message> messages, string text) {
            //filtered by message text content
            List<MobilePhoneClassLib.Message> filteredMessages = (from m in messages
                                                                  where m.Text.ToUpper().Contains(text.ToUpper())
                                                                  select m).ToList();
            return filteredMessages;
        }
        public List<Message> BetweenDates(List<Message> messages, DateTime fromDate, DateTime toDate) {
            //filtered by message receiving time
            List<MobilePhoneClassLib.Message> filteredMessages = (from m in messages
                                                                  where (m.ReceivingTime >= fromDate && m.ReceivingTime <= toDate)
                                                                  select m).ToList();
            return filteredMessages;
        }
        public List<Message> UniqueNumbers(List<Message> messages) {
            //Get unique sender numbers
            List<Message> filteredMessages = messages.GroupBy(o => new { o.SenderNumber }).Select(o => o.FirstOrDefault()).ToList();
            return filteredMessages;
        }
        public List<Message> UniqueAllFields(List<Message> messages) {
            //Get unique sender numbers
            List<Message> filteredMessages = messages.GroupBy(o => new { o.User, o.Text, o.ReceivingTime, o.SenderNumber, o.ReceiverNumber }).Select(o => o.FirstOrDefault()).ToList();
            return filteredMessages;
        }
        public List<Message> OrAllFilters(List<Message> messages, string senderNumber, string text, DateTime fromDate, DateTime toDate) {
            MessageFilter messageFilter = new MessageFilter();
            //adding results to each other
            List<Message> filteredMessages = messageFilter.NumberStartsWith(messages, senderNumber);
            filteredMessages.AddRange(messageFilter.TextContains(messages, text));
            filteredMessages.AddRange(messageFilter.BetweenDates(messages, fromDate, toDate));
            filteredMessages = messageFilter.UniqueAllFields(filteredMessages);
            return filteredMessages;
        }
        public List<Message> AndAllFilters(List<Message> messages, string senderNumber, string text, DateTime fromDate, DateTime toDate) {
            MessageFilter messageFilter = new MessageFilter();
            //cascade filtering
            List<Message> filteredMessages = messageFilter.NumberStartsWith(messages, senderNumber);
            filteredMessages = messageFilter.TextContains(filteredMessages, text);
            filteredMessages = messageFilter.BetweenDates(filteredMessages, fromDate, toDate);
            return filteredMessages;
        }

    }
}
