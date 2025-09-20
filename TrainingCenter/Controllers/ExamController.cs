using Microsoft.AspNetCore.Mvc;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Controllers
{
    public class ExamController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ExamController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var Ex = _unitOfWork.Exams.FindAllExam();

            return View(Ex);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _unitOfWork.Employees.Add(employee);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }


        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            _unitOfWork.Employees.Update(employee);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var cate = _unitOfWork.Employees.FindById(Id);

            return View(cate);
        }


        [HttpPost]
        public IActionResult Delete(Employee Emplo)
        {

            _unitOfWork.Employees.Delete(Emplo);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }
    }
}
