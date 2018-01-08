using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimCorp.IMS.MobilePhone;

namespace SimCorp.IMS.MobilePhoneClassLib {
    public class ChargerTask {
        private BatteryBase Battery;
        private CancellationTokenSource Source;
        private CancellationToken Token;
        //private Task Task;
        public ChargerTask(BatteryBase battery) {
            Battery = battery;
        }
        public void Start() {
            Source = new CancellationTokenSource();
            Token = Source.Token;
            Task t = new Task(Charge, Token);
            t.Start();
        }
        public void Stop() {
            Source.Cancel();
        }
        public void Charge() {
            while (true) {
                if (Token.IsCancellationRequested) {
                    break;
                }
                // Do the work..
                if (Battery.ChargeLevel < 100) {
                    Battery.ChargeLevel = Battery.ChargeLevel + 20;
                    Thread.Sleep(1000);
                }
            }

        }
    }
}
