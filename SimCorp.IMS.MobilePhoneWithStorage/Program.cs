using System;
using System.Windows.Forms;

namespace SimCorp.IMS.MobilePhoneWithStorage {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MobileWithStorageForm());
        }
    }
}
