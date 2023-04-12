using System;

namespace modul8_1302210128
{
    class Program
    {
        static void Main(string[] args)
        {
            BankTransferConfig.LoadConfig();
        
            string lang = BankTransferConfig.GetLang();

            if ( lang == "en")
            {
                Console.WriteLine("Please insert the amount of money to transfer:");
            }
            else if (lang == "id")
            {
                Console.WriteLine("Masukkan jumlah uang yang akan di-transfer:");
            }

            int jumlah = int.Parse(Console.ReadLine());
            int biayaTF;

            if (jumlah <= BankTransferConfig.GetThreshold())
            {
                biayaTF = BankTransferConfig.GetLowFee();
            }
            else 
            {
                biayaTF = BankTransferConfig.GetHighFee();
            }

            int nominal = jumlah + biayaTF;

            if (BankTransferConfig.GetLang() == "en")
            {
                Console.WriteLine($"TF Fee = { biayaTF}\ntotal amount = {nominal}");
            }
            else
            {
                Console.WriteLine($"Biaya TF = { biayaTF}\ntotal biaya = {nominal}");
            }

        }
        
    }
}
