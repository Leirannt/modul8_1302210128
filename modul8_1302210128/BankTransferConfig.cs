using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace modul8_1302210128
{


    class BankTransferConfig
    {
        private static string FilePath = @"D:\vscode\C#\modul8_1302210128\modul8_1302210128\bank_transfer_config.json";
        private static dynamic config;
        public static void loadConfig()
        {
            string ConfigJson = File.ReadAllText(FilePath);
            config = JsonConvert.DeserializeObject(configJson);
            config = new JObject();
            config.lang = "en";
            config.transfer = new JObject();
            config.transfer.threshold = 25000000;
            config.transfer.low_fee = 6500;
            config.transfer.high_fee = 15000;
            config.methods = new JArrray { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
            config.confirmation = new JObject();
            config.confirmation.en = "yes";
            config.confirmation.id = "ya";
        }

        public static string GetLang()
        {
            return config.lang;
        }

        public static int GetThreshold()
        {
            return config.transfer.threshold;
        }

        public static int GetLowFee()
        {
            return config.transfer.low_fee;
        }
        public static int GetHighFee()
        {
            return config.transfer.high_fee;
        }
        public static List<string> GetMethods()
        {
            return config.methods.ToObject<List<string>>();
        }
        public static string GetConfirmation(string lang)
        {
            return config.confirmation[lang];
        }
    }
}


