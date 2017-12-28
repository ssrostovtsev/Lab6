using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneClassLib {
    public class SMSGenerator {
        public void GenerateMessage(MessageStorage storage) {
            Message msg = new Message("+38000", "+380971994730", "SMS from Generator");
            storage.AddMessage(msg);
        }

    }
}
