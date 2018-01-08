using System.Threading;
using System.Threading.Tasks;
namespace SimCorp.IMS.MobilePhoneClassLib {
    internal class SMSProviderIntTask : SMSProviderIntThreadTask {
        private CancellationTokenSource Source;
        private CancellationToken Token;
        private MessageStorage Storage;
        public SMSProviderIntTask(MessageStorage messageStorage) {
            Storage = messageStorage;
        }
        public static Message SendSMS() {
            Message msg = new Message("+38000", "+380971994730", "SMS from Provider");
            return msg;
        }
        public override void SendAddSMS() {
            while (true) {
                if (Token.IsCancellationRequested) {
                    break;
                }
                // Do the work..
                Message msg = SendSMS();
                Storage.AddMessage(msg);
                Thread.Sleep(10000);
            }
        }
        public override void Start() {
            Source = new CancellationTokenSource();
            Token = Source.Token;
            Task t = new Task(SendAddSMS, Token);
            t.Start();
        }
        public override void Stop() {
            Source.Cancel();
        }
        public override void AddMessageToStorage(MessageStorage storage, Message msg) {
            storage.AddMessage(msg);
        }
        public override void DeleteMessageFromStorage(MessageStorage storage, Message msg) {
            storage.DeleteMessage(msg);
        }
    }
}
