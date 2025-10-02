using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrainingCenter.Dtos;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Controllers
{
    public class TrainingCenterCourseController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrainingCenterCourseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        private void CreateLectuersList()
        {
            IEnumerable<Lectures> cat = _unitOfWork.Lecture.FindAll().ToList();
            SelectList selectListItems = new SelectList(cat, "Id", "Name", 0);
            ViewBag.coursesdto = selectListItems;
        }

        public IActionResult Index()
        {
            var TRC = _unitOfWork.TrainingCenterCourse.FindAllTrainingCenterCourse();

            return View(TRC);
        }

        [HttpGet]
        public IActionResult Create()
        {
            //List<CourseDto> coursesdto = new List<CourseDto> { 
            //    new CourseDto{Id = 0,Name=""  }  };

            //SelectList selectListItems = new SelectList(coursesdto,"Id","Name",0);
            //ViewBag.coursesdto = selectListItems;

            CreateLectuersList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(TrainingCenterCourse TCR)
        {
            _unitOfWork.TrainingCenterCourse.Add(TCR);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var cate = _unitOfWork.TrainingCenterCourse.FindById(Id);

            return View(cate);
        }

        [HttpPost]
        public IActionResult Edit(TrainingCenterCourse TCR)
        {
            _unitOfWork.TrainingCenterCourse.Update(TCR);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var cate = _unitOfWork.TrainingCenterCourse.FindById(Id);

            return View(cate);
        }


        [HttpPost]
        public IActionResult Delete(TrainingCenterCourse TCR)
        {

            _unitOfWork.TrainingCenterCourse.Delete(TCR);

            _unitOfWork.Save();
            return RedirectToAction("Index");


        }

    }
}

