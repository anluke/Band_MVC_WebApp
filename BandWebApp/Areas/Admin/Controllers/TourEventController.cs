using Band.DataAccess.Data;
using Band.DataAccess.Repository.IRepository;
using Band.Models;
using Microsoft.AspNetCore.Mvc;

namespace BandWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TourEventController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public TourEventController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            List<TourEvent> objTourEventList = _unitOfWork.TourEvent.GetAll().ToList();
            return View(objTourEventList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TourEvent obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.TourEvent.Add(obj);
                _unitOfWork.Save();
                TempData["toast"] = "TourEvent created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }



        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            TourEvent toureventFromDb = _unitOfWork.TourEvent.Get(u => u.Id == id);
            if (toureventFromDb == null)
            {
                return NotFound();
            }
            return View(toureventFromDb);
        }


        [HttpPost]
        public IActionResult Edit(TourEvent obj)
        {

            if (ModelState.IsValid)
            {
                _unitOfWork.TourEvent.Update(obj);
                _unitOfWork.Save();
                TempData["toast"] = "TourEvent updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            TourEvent toureventFromDb = _unitOfWork.TourEvent.Get(u => u.Id == id);
            if (toureventFromDb == null)
            {
                return NotFound();
            }
            return View(toureventFromDb);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            TourEvent? obj = _unitOfWork.TourEvent.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.TourEvent.Remove(obj);
            _unitOfWork.Save();
            TempData["toast"] = "TourEvent deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
