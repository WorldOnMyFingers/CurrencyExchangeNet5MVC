using System.Collections.Generic;

namespace CurrencyExchangeNet5MVC.Models
{
    public class CurrencyPairNameValue
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string LocalCurrencySymbol { get; set; }
        public IEnumerable<CurrencyValue> Values { get; set; }
        public int Order { get; set; }
        public int fxOrder { get; set; }
        public int fxId { get; set; }
        public string Paragraph { get; set; }
        public CurrencyPairNameValue()
        {
        }
    }
}
