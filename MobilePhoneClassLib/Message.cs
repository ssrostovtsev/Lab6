using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhoneClassLib {
    public class Message {
        public Message() { }
        public Message(string senderNo,string receiverNo,string text) {
            SenderNumber = senderNo;
            ReceiverNumber = receiverNo;
            Text = text;
            ReceivingTime = DateTime.Now.Date;
            User = "User Name";
        }
        public string User { get; set; }
        public string Text { get; set; }
        public DateTime ReceivingTime { get; set; }
        public string SenderNumber { get; set; }
        public string ReceiverNumber { get; set; }
    }
}
