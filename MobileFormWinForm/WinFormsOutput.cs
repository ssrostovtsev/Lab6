using System;
using System.Windows.Forms;
using MobilePhone;

namespace MobileFormWinForm {
    public class WinFormsOutput : IOutput {
        private MobilePhoneForm MainForm;
        public WinFormsOutput(MobilePhoneForm mainForm) {
            this.MainForm = mainForm;
        }
        public void Write(string text) { }
        public void WriteLine(string text) {
            /// how to access form MobilePhoneForm component here? (making listBox public - not a good idea)
            MainForm.listBox.Items.Add(text);
        }
    }
}
