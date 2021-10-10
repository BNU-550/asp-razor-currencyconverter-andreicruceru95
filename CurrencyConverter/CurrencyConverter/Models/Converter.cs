using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CurencyConverter.Models
{
    public class Converter
    {
        [Required]
        public CurrencyEnum FromCurrency { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "The value must be greater or equal to 1")]
        public double FromAmmount { get; set; }
        [Required]
        public CurrencyEnum ToCurrency { get; set; }
    }
}
