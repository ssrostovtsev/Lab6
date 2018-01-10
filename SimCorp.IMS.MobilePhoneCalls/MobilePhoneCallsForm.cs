using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MobilePhoneClassLib;
using SimCorp.IMS.MobilePhoneClassLib;

namespace SimCorp.IMS.MobilePhoneCalls {
    public partial class MobilePhoneCallsForm : Form {
        public MobilePhoneCallsForm() {
            InitializeComponent();
            CallsStorage = new CallsStorage();
            CallsTask = new CallsTask(CallsStorage);
            CallsStorage.CallAdded += ShowAddedCall;
            CallsTask.Start();
        }
        private CallsStorage CallsStorage;
        private delegate void AddCallDelegate(Call call);
        private CallsTask CallsTask;
        private void AddCallToListBox(Call call) {
            if (this.UnsortedCallsListBox.InvokeRequired && this.UnsortedCallsListBox != null) {
                AddCallDelegate d = new AddCallDelegate(AddCallToListBox);
                this.Invoke(d, new object[] { call });
            } else {
                this.UnsortedCallsListBox.Items.Add(call.GetCallInfo());
            }
        }
        private void InitCallsStorage() {
            CallsStorage = new CallsStorage();
            CallsStorage.AddCall(new Call("+38097 01", CallType.Incoming, DateTime.Now));
            CallsStorage.AddCall(new Call("+38097 02", CallType.Incoming, DateTime.Now));
            CallsStorage.AddCall(new Call("+38097 01", CallType.Incoming, DateTime.Now));
            CallsStorage.AddCall(new Call("+38097 01", CallType.Incoming, DateTime.Now));
            CallsStorage.AddCall(new Call("+38097 02", CallType.Incoming, DateTime.Now));
            CallsStorage.AddCall(new Call("+38097 02", CallType.Incoming, DateTime.Now));
            CallsStorage.AddCall(new Call("+38097 02", CallType.Incoming, DateTime.Now));
            CallsStorage.AddCall(new Call("+38097 03", CallType.Incoming, DateTime.Now));
        }
        private void ShowAddedCall(object sender, CallEventArgs e) {
            AddCallToListBox(e.Call);
        }

        private void SortButton_Click(object sender, EventArgs e) {
            SortedCallsListBox.Items.Clear();
            List<Call> allCalls = CallsStorage.AllCalls;
            // Uses IComparable.CompareTo()
            allCalls.Sort();
            for (int i = 0; i < allCalls.Count; i++) {
                SortedCallsListBox.Items.Add(allCalls[i].GetCallInfo());
            }
        }

        private void MobilePhoneCallsForm_FormClosing(object sender, FormClosingEventArgs e) {
            CallsTask.Stop();
        }

        private void GrouCallsButton_Click(object sender, EventArgs e) {
            GroupCallsListBox.Items.Clear();
            for (int i = CallsStorage.AllCalls.Count - 1; i >= 0; i--) {
                if (CallsStorage.AllCalls[i].PreviousOccurencies.Count != 0) {
                    GroupCallsListBox.Items.Add(CallsStorage.AllCalls[i].GetCallInfoWithPreviousOccurences());
                    //skip those, that belong to the same group
                    i = i - CallsStorage.AllCalls[i].PreviousOccurencies.Count;
                }else {
                    GroupCallsListBox.Items.Add(CallsStorage.AllCalls[i].GetCallInfoWithPreviousOccurences());
                }
            }
}

        private void StopButton_Click(object sender, EventArgs e) {
            CallsTask.Stop();
            InitCallsStorage();
            UnsortedCallsListBox.Items.Clear();
            for (int i = 0; i < CallsStorage.AllCalls.Count; i++) {
                UnsortedCallsListBox.Items.Add(CallsStorage.AllCalls[i].GetCallInfo());
            }
        }
    }

}
