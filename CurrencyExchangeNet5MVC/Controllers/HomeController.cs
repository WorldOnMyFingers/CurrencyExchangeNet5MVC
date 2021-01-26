using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CurrencyExchangeNet5MVC.Models;
using IO.Swagger.Api;
using RestSharp;

namespace CurrencyExchangeNet5MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICurrencyApi _currencyApi;

        public HomeController(ILogger<HomeController> logger, ICurrencyApi currencyApi)
        {
            _logger = logger;
            _currencyApi = currencyApi;
        }

        public IActionResult Index(string id = "pkr")
        {
            var pkr = _currencyApi.CurrencyGet(id);
            pkr.LocalCurrencyCode = id.ToUpper();
            return View(pkr);
        }
         
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
