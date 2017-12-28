using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneClassLib {
    public class MessageEventArgs {
        public Message Message { get; }
        public MessageEventArgs(Message message) {
            Message = message;
        }
    }
}
