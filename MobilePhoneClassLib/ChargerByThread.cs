using System.Threading;
using SimCorp.IMS.MobilePhone;
using SimCorp.IMS.MobilePhoneClassLib;

namespace MobilePhoneClassLib {
    public class ChargerByThread {
        
        public void ChargeByThread(BatteryBase battery) {
            //Charger charger = new Charger(battery);
            //Thread chargeThread = new Thread(new ThreadStart(charger.Charge));
           // Thread chargeThread = new Thread(new ThreadStart(charger.DoWork));
           // chargeThread.Start();
        }
    }
}
