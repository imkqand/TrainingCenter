using Microsoft.AspNetCore.Mvc;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Controllers
{
    public class LecturesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public LecturesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var TRC = _unitOfWork.Lecture.FindAllLectures();

            return View(TRC);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Lectures TCR)
        {
            _unitOfWork.Lecture.Add(TCR);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var cate = _unitOfWork.Lecture.FindById(Id);

            return View(cate);
        }

        [HttpPost]
        public IActionResult Edit(Lectures TCR)
        {
            _unitOfWork.Lecture.Update(TCR);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var cate = _unitOfWork.Lecture.FindById(Id);

            return View(cate);
        }


        [HttpPost]
        public IActionResult Delete(Lectures TCR)
        {

            _unitOfWork.Lecture.Delete(TCR);

            _unitOfWork.Save();
            return RedirectToAction("Index");


        }
    }
}
