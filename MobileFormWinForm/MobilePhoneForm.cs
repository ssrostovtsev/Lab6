using System;
using System.Windows.Forms;
using MobilePhone;
using MobilePhoneClassLib;

namespace MobileFormWinForm {
    public partial class MobilePhoneForm : Form {
        public MobilePhoneForm() {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, EventArgs e) {
            OLEDScreen OLEDScreen = new OLEDScreen(768, 1024);
            LiPoBattery liPoBattery = new LiPoBattery(4100, 3.7, 83);
            MultiCoreCPU multiCoreCPU = new MultiCoreCPU("SnapDragon", 2.1, 2);
            SimCorpMobile scmobile = new SimCorpMobile(OLEDScreen, liPoBattery, multiCoreCPU);
            WinFormsOutput winFormOutput = new WinFormsOutput(this);
            listBox.Items.Clear();
            if (radioButtoniPhone.Checked == true) {
                scmobile.PlaybackComponent = new iPhoneHeadset(winFormOutput);
            } else if (radioButtonSamsung.Checked == true) {
                scmobile.PlaybackComponent = new SamsungHeadset(winFormOutput);
            } else if (radioButtonNoNameHeadset.Checked == true) {
                scmobile.PlaybackComponent = new NoNameHeadset(winFormOutput);
            } else if (radioButtonPhoneSpeaker.Checked == true) {
                scmobile.PlaybackComponent = new PhoneSpeaker(winFormOutput);
            } else {
                listBox.Items.Add("Nothing is selected");
            }
            scmobile.Play("Unknown Artist - His Song");
        }

        private void MobilePhoneForm_Load(object sender, EventArgs e) {
            radioButtoniPhone.Checked = true;
        }
    }
}
