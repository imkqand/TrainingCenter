using Microsoft.AspNetCore.Mvc;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Controllers
{
    public class CourseController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CourseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var TRC = _unitOfWork.Courses.FindAllCourses();

            return View(TRC);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course TCR)
        {
            _unitOfWork.Courses.Add(TCR);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var cate = _unitOfWork.Courses.FindById(Id);

            return View(cate);
        }

        [HttpPost]
        public IActionResult Edit(Course TCR)
        {
            _unitOfWork.Courses.Update(TCR);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var cate = _unitOfWork.Courses.FindById(Id);

            return View(cate);
        }


        [HttpPost]
        public IActionResult Delete(Course TCR)
        {

            _unitOfWork.Courses.Delete(TCR);

            _unitOfWork.Save();
            return RedirectToAction("Index");


        }
    }
}
