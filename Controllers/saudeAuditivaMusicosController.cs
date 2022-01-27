using fonoaudiologiaMariana.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace fonoaudiologiaMariana.Controllers
{
    public class saudeAuditivaMusicosController : Controller
    {
        private readonly ILogger<saudeAuditivaMusicosController> _logger;

        public saudeAuditivaMusicosController(ILogger<saudeAuditivaMusicosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
