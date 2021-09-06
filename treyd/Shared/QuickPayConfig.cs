using System;
using System.Security.Cryptography;
using System.Text;

namespace treyd.Shared
{
    public static class QuickPayConfig
    {
        public static string PRIVATE_KEY = "132a2b66a3f51b803890e93dd0ce310f53d2e171cbc2e128c5c42d258ce408f0";
        public static string API_KEY = "8c96418d15d585abdf44a0c7b707e2947cee20e1871878c37b2f323d0c4fe485";
        public static string USER = "aae6714969414c521f529e822cc1d26d3e00202d8a85b8ed4c1a2cd9348838f0";
        public static string URL = "https://treyd.azurewebsites.net";
        public static string CALLBACKURL = URL + "/api/quickpay/";

        public static string GenerateOrderNumber()
        {
            DateTime prevDate = new DateTime(1970, 1, 1);
            String[] secs = (DateTime.UtcNow - prevDate).TotalSeconds.ToString().Split(".");

            Random random = new Random();
            int randNum = random.Next(100, 1000); // Generates random number between 100 and 999

            string orderNumber = secs[0] + randNum;

            return orderNumber;
        }

        public static string Sign(string parameters)
        {
            var e = Encoding.UTF8;

            var hmac = new HMACSHA256(e.GetBytes(PRIVATE_KEY));
            byte[] b = hmac.ComputeHash(e.GetBytes(parameters));

            var s = new StringBuilder();
            for (int i = 0; i < b.Length; i++)
            {
                s.Append(b[i].ToString("x2"));
            }

            return s.ToString();
        }
    }
}
