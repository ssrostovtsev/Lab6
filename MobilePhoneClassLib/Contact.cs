using System.Collections.Generic;
namespace SimCorp.IMS.MobilePhoneClassLib {
    public class Contact {
        public Contact(List<string> phoneNos,string firstName, string lastName) {
            PhoneNumbers = phoneNos;
            FirstName = firstName;
            LastName = lastName;
        }
        public List<string> PhoneNumbers { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
