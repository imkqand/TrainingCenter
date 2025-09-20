using Microsoft.AspNetCore.Mvc;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Controllers
{
    public class LecturerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public LecturerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var cur = _unitOfWork.Lecturers.FindAllLecturer();

            return View(cur);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Lecturer lec)
        {
            _unitOfWork.Lecturers.Add(lec);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }


        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Lecturer lec)
        {
            _unitOfWork.Lecturers.Update(lec);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var cuor = _unitOfWork.Lecturers.FindById(Id);

            return View(cuor);
        }


        [HttpPost]
        public IActionResult Delete(Lecturer lec)
        {

            _unitOfWork.Lecturers.Delete(lec);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }
    }
}
