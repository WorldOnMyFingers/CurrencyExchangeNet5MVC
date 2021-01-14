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

        public IActionResult Index()
        {
            var client = new RestClient("http://www.geoplugin.net/javascript.gp");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Upgrade-Insecure-Requests", "1");
            client.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.198 Safari/537.36";
            request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var pkr = _currencyApi.CurrencyGet("pkr");
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
