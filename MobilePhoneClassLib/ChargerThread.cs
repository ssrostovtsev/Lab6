using System.Threading;
using System.Windows.Forms;
using SimCorp.IMS.MobilePhone;

namespace SimCorp.IMS.MobilePhoneClassLib {
    public class ChargerThread {
        private ManualResetEvent shutdownEvent = new ManualResetEvent(false);
        private ManualResetEvent pauseEvent = new ManualResetEvent(true);
        private Thread thread;
        private object thisLock = new object();
        private BatteryBase Battery;
        public ChargerThread(BatteryBase battery) {
            Battery = battery;
        }
        public void Start() {
            shutdownEvent.Reset();
            thread = new Thread(Charge);
            thread.Start();
        }
        public void Pause() {
            pauseEvent.Reset();
           // MessageBox.Show("Charging Paused");
        }
        public void Resume() {
            pauseEvent.Set();
           // MessageBox.Show("Charging Resumed");
        }
        public void Stop() {
            // Signal the shutdown event
            shutdownEvent.Set();
            //MessageBox.Show("Charging Stopped ");
            // Make sure to resume any paused threads
            pauseEvent.Set();
            // Wait for the thread to exit
            thread.Join();
            //thread.Abort();
        }
        public void Charge() {
            while (true) {
                pauseEvent.WaitOne(Timeout.Infinite);
                if (shutdownEvent.WaitOne(0))
                    break;
                // Do the work..
                lock (thisLock) {
                    if (Battery.ChargeLevel < 100) {
                        Battery.ChargeLevel=Battery.ChargeLevel+20;
                        //MessageBox.Show(Battery.ChargeLevel.ToString());
                        Thread.Sleep(3000);
                    }
                };
                
            }
        }
    }
}
