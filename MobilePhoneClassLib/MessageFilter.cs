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

    }
}
