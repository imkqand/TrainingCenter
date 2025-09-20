using Microsoft.AspNetCore.Mvc;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Controllers
{
    public class GradeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public GradeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var cur = _unitOfWork.Grades.FindAllGrade();

            return View(cur);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Grade Gr)
        {
            _unitOfWork.Grades.Add(Gr);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }


        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Grade gr)
        {
            _unitOfWork.Grades.Update(gr);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var cuor = _unitOfWork.Grades.FindById(Id);

            return View(cuor);
        }


        [HttpPost]
        public IActionResult Delete(Grade gr)
        {

            _unitOfWork.Grades.Delete(gr);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }
    }
}
