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
            var TRC = _unitOfWork.Students.FindAllStudent();

            return View(TRC);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student TCR)
        {
            _unitOfWork.Students.Add(TCR);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var cate = _unitOfWork.Students.FindById(Id);

            return View(cate);
        }

        [HttpPost]
        public IActionResult Edit(Student TCR)
        {
            _unitOfWork.Students.Update(TCR);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var cate = _unitOfWork.Students.FindById(Id);

            return View(cate);
        }


        [HttpPost]
        public IActionResult Delete(Student TCR)
        {

            _unitOfWork.Students.Delete(TCR);

            _unitOfWork.Save();
            return RedirectToAction("Index");


        }
    }
}
