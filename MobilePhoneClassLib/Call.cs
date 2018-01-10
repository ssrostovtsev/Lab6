using System;
using System.Collections.Generic;

namespace SimCorp.IMS.MobilePhoneClassLib {
    public enum CallType {
        Incoming = 0,
        Outgoing = 1
    }
    public class Call : IComparable<Call> {
        public Call(string phoneNo, CallType callType) {
            //Contact = contact;
            PhoneNumber = phoneNo;
            CallType = callType;
            CallTime = DateTime.Now;
            PreviousOccurencies = new List<Call>() { };
        }
        public Call(string phoneNo, CallType callType, DateTime dateTime) {
            //Contact = contact;
            PhoneNumber = phoneNo;
            CallType = callType;
            CallTime = dateTime;
            PreviousOccurencies = new List<Call>() { };
        }
        //public Contact Contact { get; set; }
        public string PhoneNumber { get; set; }
        public CallType CallType { get; set; }
        public DateTime CallTime { get; set; }
        public List<Call> PreviousOccurencies { get; set; }
        public string GetReadableCallType() {
            switch (CallType) {
                case CallType.Incoming:
                return "Incoming";
                case CallType.Outgoing:
                return "Outgoing";
                default:
                return "Unknown Type";
            }
        }
        public string GetCallInfo() {
            return "Phone number: " + PhoneNumber + " When: " + CallTime.ToLongTimeString() + " (" + GetReadableCallType() + ")";
        }
        public string GetCallInfoWithPreviousOccurences() {
            //+1 means "call itself"
            int occurances = PreviousOccurencies.Count + 1;
            return "Phone number: " + PhoneNumber + " When: " + CallTime.ToLongTimeString() + " (" + GetReadableCallType() + ") ("+occurances+")";
        }
        public int CompareTo(Call other) {
            // Desc sort if phone number is equal.
            if (this.PhoneNumber == other.PhoneNumber) {
                return other.CallTime.CompareTo(this.CallTime);
            }
            // Default to phone number sort. [High to low]
            return other.PhoneNumber.CompareTo(this.PhoneNumber);
        }
        public override bool Equals(object obj) {
            if (obj == null)
                return false;
            if (this.GetType() != obj.GetType())
                return false;
            Call call = (Call)obj;
            return (this.PhoneNumber == call.PhoneNumber) && (this.CallType == call.CallType);
        }
    }
}
