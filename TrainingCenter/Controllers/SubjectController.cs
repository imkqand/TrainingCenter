using Microsoft.AspNetCore.Mvc;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Controllers
{
    public class SubjectController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public SubjectController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var TRC = _unitOfWork.Subjectts.FindAllSubject();

            return View(TRC);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Subject TCR)
        {
            _unitOfWork.Subjectts.Add(TCR);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var cate = _unitOfWork.Subjectts.FindById(Id);

            return View(cate);
        }

        [HttpPost]
        public IActionResult Edit(Subject TCR)
        {
            _unitOfWork.Subjectts.Update(TCR);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var cate = _unitOfWork.Subjectts.FindById(Id);

            return View(cate);
        }


        [HttpPost]
        public IActionResult Delete(Subject TCR)
        {

            _unitOfWork.Subjectts.Delete(TCR);

            _unitOfWork.Save();
            return RedirectToAction("Index");


        }
    }
}
