using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobilePhoneClassLib;
using SimCorp.IMS.MobilePhone;

namespace SimCorp.IMS.MobilePhoneClassLib {
    public class CallsTask {
        private CallsStorage CallStorage;
        private CancellationTokenSource Source;
        private CancellationToken Token;
        private object thisLock = new object();
        //private Task Task;
        public CallsTask(CallsStorage callStorage) {
            CallStorage = callStorage;
        }
        public static Call GenerateCall() {
            //add Rnd logic here
            Random rndNum = new Random();
            int lastNumber = rndNum.Next(1);
            Random rndType = new Random();
            int type = rndType.Next(3);
            CallType cType = CallType.Incoming;
            switch (type) {
                case 0:
                cType = CallType.Incoming;
                break;
                case 1:
                cType = CallType.Outgoing;
                break;
                default:
                break;
            }
            Call call = new Call("+38097 0" + lastNumber.ToString(), cType);
            return call;
        }
        public void Start() {
            Source = new CancellationTokenSource();
            Token = Source.Token;
            Task t = new Task(AddCall, Token);
            t.Start();
        }
        public void Stop() {
            Source.Cancel();
        }
        public void AddCall() {
            while (true) {
                if (Token.IsCancellationRequested) {
                    break;
                }
                lock (thisLock) {
                    // Do the work...
                    Call call = GenerateCall();
                    CallStorage.AddCall(call);
                    Thread.Sleep(1000);
                };
            }

        }
    }
}
