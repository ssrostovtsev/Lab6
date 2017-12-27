using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MobilePhoneClassLib;

namespace SimCorp.IMS.MobilePhoneWithStorage {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            MsgStorage = InitMessageStorage();
            InitSMSNumberComboBox(MsgStorage);
        }
        private MessageStorage MsgStorage;
        private void InitSMSNumberComboBox(MessageStorage messageStorage) {
            List<MobilePhoneClassLib.Message> messages = messageStorage.GetAllMessages();
            MessageFilter messageFilter = new MessageFilter();
            List<MobilePhoneClassLib.Message> filteredMessages = messageFilter.UniqueNumbers(messages);
            foreach (MobilePhoneClassLib.Message message in filteredMessages) {
                SMSNumberComboBox.Items.Add(message.SenderNumber);
            }
        }
        private MessageStorage InitMessageStorage() {
            string phoneNo = "+380971994730";
            MessageStorage messageStorage = new MessageStorage(phoneNo);
            for (int i = 0; i < 1000; i++) {
                MobilePhoneClassLib.Message message = new MobilePhoneClassLib.Message($"+38{i}", phoneNo, $"Message #{i}");
                messageStorage.AddMessage(message);
            }
            return messageStorage;
        }
        private void ShowMessages(List<MobilePhoneClassLib.Message> messages) {
            MessageListBox.Items.Clear();
            foreach (MobilePhoneClassLib.Message message in messages) {
                MessageListBox.Items.Add("From: " + message.SenderNumber + ", Date: " + message.ReceivingTime.ToString() + ", Text: " + message.Text);
            }
        }

        private void ApplyFilterButton_Click(object sender, System.EventArgs e) {
            List<MobilePhoneClassLib.Message> messages = MsgStorage.GetAllMessages();
            ////LINQ here
            ////filtered by sender number
            //List<MobilePhoneClassLib.Message> filteredMessages = (from m in messages
            //                                                      where m.SenderNumber.ToUpper().StartsWith(SMSNumberComboBox.Text.ToUpper())
            //                                                      select m).ToList();
            ////filtered by message text content
            //List<MobilePhoneClassLib.Message> filteredMessages2 = (from m in messages
            //                                                      where m.Text.ToUpper().Contains(SMSTextTextBox.Text.ToUpper())
            //                                                      select m).ToList();
            ////filtered by message receiving time
            //List<MobilePhoneClassLib.Message> filteredMessages3 = (from m in messages
            //                                                       where (m.ReceivingTime>= FromDateTimePicker.Value&& m.ReceivingTime <= ToDateTimePicker.Value)
            //                                                       select m).ToList();

            //List<MobilePhoneClassLib.Message> filteredMessages;
            //if (OrCheckBox.Checked) {
            //    filteredMessages = (from m in messages
            //                        where (
            //                        (m.SenderNumber.ToUpper().StartsWith(SMSNumberComboBox.Text.ToUpper()))
            //                        || (m.Text.ToUpper().Contains(SMSTextTextBox.Text.ToUpper()))
            //                        || (m.ReceivingTime >= FromDateTimePicker.Value && m.ReceivingTime <= ToDateTimePicker.Value)
            //                        )
            //                        select m).ToList();
            //    ShowMessages(filteredMessages);
            //} else {
            //    filteredMessages = (from m in messages
            //                        where (
            //                        (m.SenderNumber.ToUpper().StartsWith(SMSNumberComboBox.Text.ToUpper()))
            //                        && (m.Text.ToUpper().Contains(SMSTextTextBox.Text.ToUpper()))
            //                        && (m.ReceivingTime >= FromDateTimePicker.Value && m.ReceivingTime <= ToDateTimePicker.Value)
            //                        )
            //                        select m).ToList();
            //    ShowMessages(filteredMessages);
            //}

            List<MobilePhoneClassLib.Message> filteredMessages;
            MessageFilter messageFilter = new MessageFilter();
            if (OrCheckBox.Checked) {
                //adding results to each other
                filteredMessages = messageFilter.NumberStartsWith(messages, SMSNumberComboBox.Text.ToUpper());
                filteredMessages.AddRange(messageFilter.TextContains(messages, SMSTextTextBox.Text.ToUpper()));
                filteredMessages.AddRange(messageFilter.BetweenDates(messages, FromDateTimePicker.Value, ToDateTimePicker.Value));
                ShowMessages(filteredMessages);
            } else {
                //cascade filtering
                filteredMessages = messageFilter.NumberStartsWith(messages, SMSNumberComboBox.Text.ToUpper());
                filteredMessages = messageFilter.TextContains(filteredMessages, SMSTextTextBox.Text.ToUpper());
                filteredMessages = messageFilter.BetweenDates(filteredMessages, FromDateTimePicker.Value, ToDateTimePicker.Value);
                ShowMessages(filteredMessages);
            }
            //ShowMessages(filteredMessages);
        }
    }
}
