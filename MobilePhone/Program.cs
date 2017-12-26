using System;
using MobilePhoneClassLib;

namespace MobilePhone {
    class Program {
        static void Main(string[] args) {
            OLEDScreen OLEDScreen = new OLEDScreen(768, 1024);
            LiPoBattery liPoBattery = new LiPoBattery(4100, 3.7, 83);
            MultiCoreCPU multiCoreCPU = new MultiCoreCPU("SnapDragon", 2.1, 2);
            SimCorpMobile scmobile = new SimCorpMobile(OLEDScreen, liPoBattery, multiCoreCPU);
            ConsoleOutput consoleOutput = new ConsoleOutput();
            Console.WriteLine("Select playback component (specify index):");
            Console.WriteLine($"1  - { nameof(iPhoneHeadset)}");
            Console.WriteLine($"2  - { nameof(SamsungHeadset)}");
            Console.WriteLine($"3  - { nameof(NoNameHeadset)}");
            Console.WriteLine($"4  - { nameof(PhoneSpeaker)}");
            Console.WriteLine($"Esc  - Exit");
            ConsoleKeyInfo cki;
            do {
                cki = Console.ReadKey(true);
                if (cki.Key.ToString() == "D1") {
                    scmobile.PlaybackComponent = new iPhoneHeadset(consoleOutput);
                    scmobile.Play("Unknown Artist - His Song");
                } else if (cki.Key.ToString() == "D2") {
                    scmobile.PlaybackComponent = new SamsungHeadset(consoleOutput);
                    scmobile.Play("Unknown Artist - His Song");
                } else if (cki.Key.ToString() == "D3") {
                    scmobile.PlaybackComponent = new NoNameHeadset(consoleOutput);
                    scmobile.Play("Unknown Artist - His Song");
                } else if (cki.Key.ToString() == "D4") {
                    scmobile.PlaybackComponent = new PhoneSpeaker(consoleOutput);
                    scmobile.Play("Unknown Artist - His Song");
                } else if (cki.Key != ConsoleKey.Escape) {
                    Console.WriteLine("Wrong selection, try again.");
                }
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
