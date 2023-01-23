using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;


namespace WpfAppCrypto
{

    public static class APIData 
    {
        public static List<Currency> GetCurrency()
        {
            List<Currency> currencies = new List<Currency>();
            string url = "https://api.coincap.io/v2/assets";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            JObject job = JObject.Parse(json: response);

            List<JToken> results = job["data"].Children().ToList();

            foreach (JToken result in results)
            {
                Currency currency = result.ToObject<Currency>(); 
                currencies.Add(currency);
            }

            return currencies;
        }
    }
}
