using Band.DataAccess.Repository.IRepository;
using Band.Models;
using Microsoft.AspNetCore.Mvc;

namespace BandWebApp.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class StoreController : Controller
    {
        private readonly ILogger<StoreController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public StoreController(ILogger<StoreController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category");
            return View(productList);
        }
    }
}
