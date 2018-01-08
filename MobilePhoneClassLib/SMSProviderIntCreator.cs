using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimCorp.IMS.MobilePhoneClassLib;

namespace SimCorp.IMS.MobilePhoneClassLib {
    public enum SMSProviderIntType {
        Task,
        Thread
    }
    internal class SMSProviderIntCreator {
        internal SMSProviderIntThreadTask GetSMSProvider(MessageStorage storage,SMSProviderIntType type) {
            switch (type) {
                case SMSProviderIntType.Task:
                return new SMSProviderIntTask(storage);
                case SMSProviderIntType.Thread:
                return new SMSProviderIntThread(storage);
                default:
                throw new NotSupportedException();
            }
        }
    }
}
