using System.Threading;
using System.Windows.Forms;
using SimCorp.IMS.MobilePhone;

namespace SimCorp.IMS.MobilePhoneClassLib {
    public class ChargerOld {
        private BatteryBase Battery;
        private object thisLock = new object();
        public ChargerOld(BatteryBase battery) {
            Battery = battery;
        }
        public void Charge() {
            lock (thisLock) {
                while (Battery.ChargeLevel < 100) {
                    Battery.ChargeLevel++;
                    Thread.Sleep(1000);
                }
            }
        }

        private void Discharge() {
            lock (thisLock) {
                while (Battery.ChargeLevel > 0) {
                    Battery.ChargeLevel--;
                    Thread.Sleep(2000);
                }
            }
        }
    }
}