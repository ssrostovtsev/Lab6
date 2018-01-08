using System.Threading;
using System.Threading.Tasks;
using SimCorp.IMS.MobilePhone;

namespace SimCorp.IMS.MobilePhoneClassLib {
    public class DischargerTask {
        private BatteryBase Battery;
        private CancellationTokenSource Source;
        private CancellationToken Token;
        public DischargerTask(BatteryBase battery) {
            Battery = battery;
        }
        public void Start() {
            Source = new CancellationTokenSource();
            Token = Source.Token;
            Task task = new Task(Discharge,Token);
            task.Start();
        }
        public void Stop() {
            Source.Cancel();
        }
        public void Discharge() {
            while (true) {
                if (Token.IsCancellationRequested) {
                    break;
                }
                // Do the work..
                if (Battery.ChargeLevel > 0) {
                    Battery.ChargeLevel = Battery.ChargeLevel - 15;
                    Thread.Sleep(2000);
                }

            }
        }
    }
}
