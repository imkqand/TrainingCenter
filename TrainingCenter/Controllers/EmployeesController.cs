using Microsoft.AspNetCore.Mvc;
using TrainingCenter.Data;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var employees = _unitOfWork.Employees.FindAllEmployee();
    
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {

            //_context.Employees.Add(employee);
            //_context.SaveChanges();
            _unitOfWork.Employees.Add(employee);
            _unitOfWork.Save();
            TempData["Add"] = "تم اضافة البيانات بنجاح";
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

            //_context.Employees.Add(employee);
            //_context.SaveChanges();
            _unitOfWork.Employees.Update(employee);
            _unitOfWork.Save();
            TempData["Add"] = "تم اضافة البيانات بنجاح";
            return RedirectToAction("Index");


        }




    }
}
