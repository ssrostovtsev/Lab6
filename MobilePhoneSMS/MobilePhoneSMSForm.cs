﻿using System;
using System.Windows.Forms;
using SimCorp.IMS.MobilePhoneClassLib;
using static SimCorp.IMS.MobilePhoneClassLib.SMSProvider;

namespace MobilePhoneSMS {
    public partial class MobilePhoneSMSForm : Form {
        public MobilePhoneSMSForm() {
            InitializeComponent();
            SMSProv = new SMSProvider();
            SMSProv.SMSRecieved += new SMSRecievedHandler(ShowSMS);
            string[] formats = new string[] { "None", "Start with DateTime", "End with DateTime", "Lowercase", "Uppercase" };
            FmtComboBox.Items.AddRange(formats);
            FmtComboBox.Text = "None";
        }
        private int i = 0;
        private SMSProvider SMSProv;
        private string Fmt = "None";

        private void AddSMSTimer_Tick_1(object sender, EventArgs e) {
            string msg = "Message #" + Convert.ToString(i++);
            SMSProv.SendSMS(msg, Fmt);
        }

        private void ShowSMS(string str) {
            MessageListBox.Items.Add(str);
        }

        private void FmtComboBox_SelectedValueChanged(object sender, EventArgs e) {
            Fmt = FmtComboBox.Text;
        }

    }
}
