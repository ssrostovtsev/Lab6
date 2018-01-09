using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using SimCorp.IMS.MobilePhone;
using SimCorp.IMS.MobilePhoneClassLib;

namespace SimCorp.IMS.MobilePhoneWithThreadingTasks {
    public partial class MobilePhoneWithTreadingTasksForm : Form {
        public MobilePhoneWithTreadingTasksForm() {
            InitializeComponent();
            SimCorpMobileThreadTask = InitSimCorpMobileThreadTask();
            MsgStorage = SimCorpMobileThreadTask.MessageStorage;
            InitSMSNumberComboBox(MsgStorage);
            InitDateTimePickers();
            MsgStorage.MessageAdded += ShowAddedMessage;
            MsgStorage.MessageDeleted += ShowDeletedMessages;
            //Start background worker
            ChargeBackgroundWorker.RunWorkerAsync();
            //Start charging
            //ChargerThread = new ChargerThread(SimCorpMobile.Battery);
            //ChargerThread.Start();
            ChargerTask = new ChargerTask(SimCorpMobileThreadTask.Battery);
            ChargerTask.Start();
            IsCharging = true;
            ChargeButton.Text = "Stop charging";
            //Start discharging
            //DischargerThread = new DischargerThread(SimCorpMobile.Battery);
            //DischargerThread.Start();
            DischargerTask = new DischargerTask(SimCorpMobileThreadTask.Battery);
            DischargerTask.Start();
            //Start sending SMS by Thread or by Task
            SimCorpMobileThreadTask.StartGenerateSMS();
        }
        private SimCorpMobileThreadTask SimCorpMobileThreadTask;
        private string MyPhoneNo = "+380971994730";
        //private ChargerThread ChargerThread;
        //private DischargerThread DischargerThread;
        private ChargerTask ChargerTask;
        private DischargerTask DischargerTask;
        private bool IsCharging = false;
        private MessageStorage MsgStorage;
        private delegate void AddMessageDelegate(MobilePhoneClassLib.Message msg);
        private SimCorpMobileThreadTask InitSimCorpMobileThreadTask() {
            OLEDScreen OLEDScreen = new OLEDScreen(768, 1024);
            LiPoBattery liPoBattery = new LiPoBattery(4100, 3.7, 20);
            MultiCoreCPU multiCoreCPU = new MultiCoreCPU("SnapDragon", 2.1, 2);
            MessageStorage messageStorage = InitMessageStorage(MyPhoneNo);
            SimCorpMobileThreadTask scmobile = new SimCorpMobileThreadTask(OLEDScreen, liPoBattery, multiCoreCPU, messageStorage);
            scmobile.MessageStorage = messageStorage;
            return scmobile;
        }
        private MessageStorage InitMessageStorage(string phoneNo) {
            MessageStorage messageStorage = new MessageStorage(phoneNo);
            for (int i = 0; i < 1000; i++) {
                MobilePhoneClassLib.Message message = new MobilePhoneClassLib.Message($"+38{i}", phoneNo, $"Message #{i}");
                messageStorage.AddMessage(message);
            }
            return messageStorage;
        }
        private void InitSMSNumberComboBox(MessageStorage messageStorage) {
            List<MobilePhoneClassLib.Message> messages = messageStorage.GetAllMessages();
            MessageFilter messageFilter = new MessageFilter();
            List<MobilePhoneClassLib.Message> filteredMessages = messageFilter.UniqueNumbers(messages);
            foreach (MobilePhoneClassLib.Message message in filteredMessages) {
                SMSNumberComboBox.Items.Add(message.SenderNumber);
            }
        }
        private void InitDateTimePickers() {
            FromDateTimePicker.Value= DateTime.Today.AddDays(-1);
            ToDateTimePicker.Value = DateTime.Today;
        }
        private void ShowMessages(List<MobilePhoneClassLib.Message> messages) {
            MessageListBox.Items.Clear();
            foreach (MobilePhoneClassLib.Message message in messages) {
                MessageListBox.Items.Add("From: " + message.SenderNumber + ", Date: " + message.ReceivingTime.ToString() + ", Text: " + message.Text);
            }
        }
        private void ApplyFilterButton_Click(object sender, EventArgs e) {
            List<MobilePhoneClassLib.Message> messages = MsgStorage.GetAllMessages();
            List<MobilePhoneClassLib.Message> filteredMessages;
            MessageFilter messageFilter = new MessageFilter();
            if (OrCheckBox.Checked) {
                filteredMessages = messageFilter.OrAllFilters(messages, SMSNumberComboBox.Text.ToUpper(), SMSTextTextBox.Text.ToUpper(), FromDateTimePicker.Value, ToDateTimePicker.Value);
                ShowMessages(filteredMessages);
            } else {
                filteredMessages = messageFilter.AndAllFilters(messages, SMSNumberComboBox.Text.ToUpper(), SMSTextTextBox.Text.ToUpper(), FromDateTimePicker.Value, ToDateTimePicker.Value);
                ShowMessages(filteredMessages);
            }
        }

        private void ChargeButton_Click(object sender, EventArgs e) {
            if (IsCharging) {
                //ChargerThread.Stop();
                //ChargerThread.Pause();
                ChargerTask.Stop();
                IsCharging = false;
                ChargeButton.Text = "Start charging";
            } else {
                //ChargerThread.Start();
                //ChargerThread.Resume();
                ChargerTask.Start();
                IsCharging = true;
                ChargeButton.Text = "Stop charging";
            }
        }
        private void MobilePhoneWithTreadingTasksForm_FormClosed(object sender, FormClosedEventArgs e) {
            ChargerTask.Stop();
            DischargerTask.Stop();
            SimCorpMobileThreadTask.StopGenerateSMS();
        }

        private void ChargeBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) {
            while (true) {
                // Report progress.
                Thread.Sleep(500);
                ChargeBackgroundWorker.ReportProgress(SimCorpMobileThreadTask.Battery.ChargeLevel);
            }
        }

        private void ChargeBackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e) {
            ChargeProgressBar.Value = e.ProgressPercentage;
        }
        private void ShowAddedMessage(object sender, MessageEventArgs e) {
            //MessageBox.Show("Text: " + e.Message.Text + " From: " + e.Message.SenderNumber);
            AddMessageToListBox(e.Message);
        }
        private void AddMessageToListBox(MobilePhoneClassLib.Message msg) {
            if (this.MessageListBox.InvokeRequired&&this.MessageListBox!=null) {
                AddMessageDelegate d = new AddMessageDelegate(AddMessageToListBox);
                this.Invoke(d, new object[] { msg });
            } else {
                string text = "Text: " + msg.Text + " From: " + msg.SenderNumber;
                this.MessageListBox.Items.Add(text);
            }
        }
        private static void ShowDeletedMessages(object sender, MessageEventArgs e) {
            MessageBox.Show("Message from: " + e.Message.SenderNumber + " has been deleted");
        }
    }
}
