using Microsoft.AspNetCore.Mvc;
using BLL.Services;

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
