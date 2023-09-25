using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _16_projetoMVC.Controllers
{
    [Route("[controller]")]
    public class Exercicico2Controller : Controller
    {
        private readonly ILogger<Exercicico2Controller> _logger;

        public Exercicico2Controller(ILogger<Exercicico2Controller> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}