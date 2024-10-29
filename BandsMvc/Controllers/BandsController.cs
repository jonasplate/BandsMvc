using BandsMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BandsMvc.Controllers
{
    public class BandsController : Controller
    {
        private readonly DataService dataService = new DataService();

        [HttpGet("")]
        public IActionResult Index()
        {
            var bands = dataService.GetAllBands();
            return View(bands);
        }

        [HttpGet("Details/{id}")]
        public IActionResult Details(int id)
        {
            var band = dataService.GetBandById(id);
            return View(band);
        }
    }
}
