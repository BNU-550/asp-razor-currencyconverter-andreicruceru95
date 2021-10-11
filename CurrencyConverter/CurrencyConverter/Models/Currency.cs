using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Models
{
    /// <summary>
    /// Provides object model for the JSON data extracted.
    /// </summary>
    public class Currency
    {
        public string Success { get; set; }
        public string Timestamp { get; set; }
        public string BaseCurrency { get; set; }
        public string Date { get; set; }
        public Dictionary<string, double> Rates { get; set; }
    }
}
