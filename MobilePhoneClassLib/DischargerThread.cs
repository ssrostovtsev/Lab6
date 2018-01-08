using System.Threading;
using System.Windows.Forms;
using SimCorp.IMS.MobilePhone;

namespace SimCorp.IMS.MobilePhoneClassLib {
    public class DischargerThread {
        private ManualResetEvent shutdownEvent = new ManualResetEvent(false);
        private ManualResetEvent pauseEvent = new ManualResetEvent(true);
        private Thread thread;
        private object thisLock = new object();
        private BatteryBase Battery;
        public DischargerThread(BatteryBase battery) {
            Battery = battery;
        }
        public void Start() {
            thread = new Thread(Discharge);
            thread.Start();
        }
        
        public void Stop() {
            // Signal the shutdown event
            shutdownEvent.Set();
            MessageBox.Show("Discharging Stopped ");
            // Make sure to resume any paused threads
            pauseEvent.Set();
            // Wait for the thread to exit
            thread.Join();
        }
        public void Discharge() {
            while (true) {
                pauseEvent.WaitOne(Timeout.Infinite);
                if (shutdownEvent.WaitOne(0))
                    break;
                // Do the work..
                lock (thisLock) {
                    if (Battery.ChargeLevel > 0) {
                        Battery.ChargeLevel= Battery.ChargeLevel-15;
                        Thread.Sleep(2000);
                    }
                };
                
            }
        }
    }
}
