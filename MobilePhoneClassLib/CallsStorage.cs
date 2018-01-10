using System.Collections.Generic;
using SimCorp.IMS.MobilePhoneClassLib;

namespace MobilePhoneClassLib {
    public class CallsStorage {
        public delegate void CallHandler(object sender, CallEventArgs e);
        public event CallHandler CallAdded;
        public CallsStorage() {
            AllCalls = new List<Call> { };
        }
        public List<Call> AllCalls { set; get; }
        public void AddCall(Call call) {
            //add to group of previous occurencies:
            if (AllCalls.Count != 0) {
                if (call.Equals(AllCalls[AllCalls.Count - 1])) {
                    //add last saved call
                    call.PreviousOccurencies.Add(AllCalls[AllCalls.Count - 1]);
                    //add all previous call from the last saved call
                    call.PreviousOccurencies.AddRange(AllCalls[AllCalls.Count - 1].PreviousOccurencies);
                }
            }
            AllCalls.Add(call);
            if (CallAdded != null) {
                CallAdded(this, new CallEventArgs(call));
            }
        }
        public void RemoveCallsByNumber(string phoneNo) {
            for (int i = AllCalls.Count - 1; i >= 0; i--) {
                if (AllCalls[i].PhoneNumber == phoneNo) {
                    AllCalls.RemoveAt(i);
                }
            }
        }
    }
}
