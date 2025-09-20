using Microsoft.AspNetCore.Mvc;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Controllers
{
    public class CuorseController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CuorseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var cur = _unitOfWork.Cuorses.FindAllCuorse();

            return View(cur);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cuorse cuorse)
        {
            _unitOfWork.Cuorses.Add(cuorse);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }


        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Cuorse cuorse)
        {
            _unitOfWork.Cuorses.Update(cuorse);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var cuor = _unitOfWork.Cuorses.FindById(Id);

            return View(cuor);
        }


        [HttpPost]
        public IActionResult Delete(Cuorse cuorse)
        {

            _unitOfWork.Cuorses.Delete(cuorse);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }
    }
}
