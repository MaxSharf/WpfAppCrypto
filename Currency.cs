using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace WpfAppCrypto
{
    public class CurrencyCollection
    {
        public List<Currency> list { set; get; }
        public List<Currency> wallet { set; get; }
        public CurrencyCollection()
        {
            list = APIData.GetCurrency();
            wallet = new List<Currency>();
        }
    }

    public class Currency
    {
         
        public string id { get; set; }
        public string rank { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public string supply { get; set; }
        public string maxSupply { get; set; }
        public string marketCapUsd { get; set; }
        public string volumeUsd24Hr { get; set; }
        public string priceUsd { get; set; }
        public string changePercent24Hr { get; set; }
        public string vwap24Hr { get; set; }
        public string explorer { get; set; }

        public static implicit operator List<object>(Currency? v)
        {
            throw new NotImplementedException();
        }
        
    }



}
