using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using VayCayPlannerWeb.Contracts;
using VayCayPlannerWeb.Models;
using VayCayPlannerWeb.Models.ViewModels;

namespace VayCayPlannerWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITripRepository _context;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, ITripRepository tripRepository, IMapper mapper)
        {
            _logger = logger;
            _context = tripRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET: Trips
        public async Task<IActionResult> Trips()
        {
            //does this subscriber a member of a travel group

            var trips = _mapper.Map<List<Trip_vm>>(await _context.GetAllAsync());
            return View(trips);
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