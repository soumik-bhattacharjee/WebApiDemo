using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCProject.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MVCProject.Controllers
{
    public class MyWebsiteController : Controller
    {
        private readonly ILogger<MyWebsiteController> _logger;

        private IConfiguration Configuration;
        public MyWebsiteController(ILogger<MyWebsiteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() 
        {
            //ViewBag.Title = "Home Page";
            using (var client = new System.Net.Http.HttpClient())
            { 
               // client.BaseAddress = new Uri("https://localhost:44383/customer");
              //  var responseTask = client.GetStringAsync("https://localhost:44383/customer");
             //   responseTask.Wait();
             //   var result = responseTask.Result; 
                return View();
            }

           
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
