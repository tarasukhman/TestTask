using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Models;
using TestTask.Services;

namespace TestTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService _service;

        public HomeController(IService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var dataFromAllEntities = _service.GetAllData().Result;
            
            return View(dataFromAllEntities);
        }
        [HttpPost]
        public IActionResult Index(string filter)
        {
            var filteredData = _service.GetDataWithFilter(filter);

            return View(filteredData);
        }


    }
}
