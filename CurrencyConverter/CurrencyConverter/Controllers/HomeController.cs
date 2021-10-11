using CurrencyConverter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System;

namespace CurrencyConverter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        const string API_KEY = "e5545d3251a369e6791a2dd967fe686f";
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();//input);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(UserInput input)
        {
           HttpContext.Session.SetString("Name", input.Name);

            return RedirectToAction("Convert");
        }

        [HttpGet]
        public IActionResult Convert()
        {
            if(string.IsNullOrEmpty(HttpContext.Session.GetString("Name")))
            {
                return RedirectToAction("Index");
            }

            ViewData["Name"] = HttpContext.Session.GetString("Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Convert(Converter data)
        {
            ViewData["Name"] = HttpContext.Session.GetString("Name");
            ViewData["From"] = data.FromCurrency.ToString();
            ViewData["To"] = data.ToCurrency.ToString();
            ViewData["Amount"] = data.FromAmmount.ToString();

            if (data.FromCurrency == data.ToCurrency)
            {
                return View();
            }

            string baseCurrency = data.FromCurrency.ToString();
            string toCurrency = data.ToCurrency.ToString();
            double amount = data.FromAmmount;

            Currency currency = GetData().Result;

            if(currency.Success == "true")
            {
                double baseConversion = 1 / currency.Rates[baseCurrency];
                double toConversion = currency.Rates[toCurrency];

                double rate = amount * baseConversion * toConversion;
                rate = Math.Round(rate, 2);

                //HttpContext.Session.SetString("Rate", rate.ToString());
                ViewData["Rate"] = rate; //HttpContext.Session.GetString("Rate");
            }
            
            return View();
        }

        private async Task<Currency> GetData()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"http://data.fixer.io/api/latest?access_key={API_KEY}");
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();

            Currency currencyData = JsonConvert.DeserializeObject<Currency>(responseBody);

            return currencyData;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
