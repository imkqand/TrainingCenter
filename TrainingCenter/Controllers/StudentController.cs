using Microsoft.AspNetCore.Mvc;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Controllers
{
    public class StudentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var cur = _unitOfWork.Students.FindAllStudent();

            return View(cur);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student st)
        {
            _unitOfWork.Students.Add(st);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }


        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Student st)
        {
            _unitOfWork.Students.Update(st);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var cuor = _unitOfWork.Students.FindById(Id);

            return View(cuor);
        }


        [HttpPost]
        public IActionResult Delete(Student st)
        {

            _unitOfWork.Students.Delete(st);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }
    }
}
