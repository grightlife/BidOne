using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CodeTest.Models;

namespace CodeTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/api/createNewPeople")]
        public People Post([FromBody] People req)
        {
            People resp = new People();
            Console.WriteLine("344334");
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            return resp;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

