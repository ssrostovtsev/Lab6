using System.Threading;
using System.Threading.Tasks;
namespace SimCorp.IMS.MobilePhoneClassLib {
    internal class SMSProviderIntThread : SMSProviderIntThreadTask {
        private MessageStorage Storage;
        private ManualResetEvent shutdownEvent = new ManualResetEvent(false);
        private ManualResetEvent pauseEvent = new ManualResetEvent(true);
        private Thread thread;
        private object thisLock = new object();
        public SMSProviderIntThread(MessageStorage messageStorage) {
            Storage = messageStorage;
        }
        public static Message SendSMS() {
            Message msg = new Message("+38000", "+380971994730", "SMS from Provider");
            return msg;
        }
        public override void SendAddSMS() {
            while (true) {
                pauseEvent.WaitOne(Timeout.Infinite);
                if (shutdownEvent.WaitOne(0))
                    break;
                // Do the work..
                lock (thisLock) {
                    Message msg = SendSMS();
                    Storage.AddMessage(msg);
                    Thread.Sleep(10000);
                };

            }
        }
        public override void Start() {
            shutdownEvent.Reset();
            thread = new Thread(SendAddSMS);
            thread.Start();
        }
        public override void Stop() {
            // Signal the shutdown event
            shutdownEvent.Set();
            //MessageBox.Show("Charging Stopped ");
            // Make sure to resume any paused threads
            pauseEvent.Set();
            // Wait for the thread to exit
            thread.Join();
        }
        public override void AddMessageToStorage(MessageStorage storage, Message msg) {
            storage.AddMessage(msg);
        }
        public override void DeleteMessageFromStorage(MessageStorage storage, Message msg) {
            storage.DeleteMessage(msg);
        }
    }
}
