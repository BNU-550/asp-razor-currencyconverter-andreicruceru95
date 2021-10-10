using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Models
{   
    public class Converter
    {       
        [Required]
        [Display(Name ="Base Currency")]
        public CurrencyEnum FromCurrency { get; set; }

        [Required]
        [Display(Name ="Amount to exchange")]
        [Range(1, int.MaxValue, ErrorMessage = "The value must be greater or equal to 1")]
        public double FromAmmount { get; set; }

        [Required]
        [Display(Name = "Exchange Currency")]
        public CurrencyEnum ToCurrency { get; set; }        
    }
}
