using Band.DataAccess.Repository.IRepository;
using Band.Models;
using Microsoft.AspNetCore.Mvc;

namespace BandWebApp.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class TourController : Controller
    {
        private readonly ILogger<TourController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public TourController(ILogger<TourController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            IEnumerable<TourEvent> tourList = _unitOfWork.TourEvent.GetAll();
            return View(tourList);
        }
    }
}
