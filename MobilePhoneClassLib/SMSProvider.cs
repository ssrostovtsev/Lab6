using System;

namespace MobilePhoneClassLib {
    public class SMSProvider {
        public delegate void SMSRecievedHandler(string message);
        private delegate string FormatDelegate(string text);
        public event SMSRecievedHandler SMSRecieved;
        public void SendSMS(string smsText, string fmt) {
            OnSMSRecieved(smsText, fmt);
        }
        protected virtual void OnSMSRecieved(string message, string fmt) {
            var handler = SMSRecieved;
            string formattedMessage = message;
            if (handler != null) {
                if (fmt == "None") {
                    FormatDelegate Formatter = new FormatDelegate(FormatNone);
                    formattedMessage = Formatter(message);
                } else if (fmt == "Start with DateTime") {
                    FormatDelegate Formatter = new FormatDelegate(FormatStartWithTime);
                    formattedMessage = Formatter(message);
                } else if (fmt == "End with DateTime") {
                    FormatDelegate Formatter = new FormatDelegate(FormatEndWithTime);
                    formattedMessage = Formatter(message);
                } else if (fmt == "Lowercase") {
                    FormatDelegate Formatter = new FormatDelegate(FormatLowerCase);
                    formattedMessage = Formatter(message);
                } else if (fmt == "Uppercase") {
                    FormatDelegate Formatter = new FormatDelegate(FormatUpperCase);
                    formattedMessage = Formatter(message);
                }

                handler(formattedMessage);
            }
        }
        private string FormatNone(string message) {
            return message;
        }
        private string FormatStartWithTime(string message) {
            return $"[{DateTime.Now}] {message}";
        }
        private string FormatEndWithTime(string message) {
            return $"{message} [{DateTime.Now}]";
        }

        private string FormatLowerCase(string message) {
            return $"{message.ToLower()}";
        }
        private string FormatUpperCase(string message) {
            return $"{message.ToUpper()}";
        }
    }
}
