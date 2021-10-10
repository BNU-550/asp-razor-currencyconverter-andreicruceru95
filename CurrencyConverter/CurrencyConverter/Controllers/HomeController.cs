﻿using CurrencyConverter.Models;
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
            string name = HttpContext.Session.GetString("Name");
            ViewData["Name"] = name;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Convert(Converter data)
        {
            string baseCurrency = data.FromCurrency.ToString();
            string toCurrency = data.ToCurrency.ToString();
            double amount = data.FromAmmount;

            Currency currency = GetData().Result;

            if(currency.Success == "true")
            {
                double baseConversion = 1 / currency.Rates[baseCurrency];
                double toConversion = 1 / currency.Rates[toCurrency];

                double rate = baseConversion * toConversion;
                rate = Math.Round(rate, 2);

                ViewData["Rate"] = rate;
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
