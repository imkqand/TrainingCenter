//// =============================================================
//// Institute Management System (ASP.NET Core MVC, EF Core)
//// نسخة مشروحة بالكامل بالعربي (تعليقات بعد كل خطوة أساسية)
//// =============================================================

//// =========================
//// Models
//// =========================
//namespace IMS.Models
//{
//    using System; // // استيراد الأنواع العامة مثل DateTime
//    using System.Collections.Generic; // // لاستخدام قوائم ICollection/List
//    using System.ComponentModel.DataAnnotations; // // لاستخدام سمات التحقق مثل [Required]

//    // ================= Student =================
//    public class Student
//    {
//        public int Id { get; set; } // // المفتاح الأساسي للطالب

//        [Required, MaxLength(100)] public string Name { get; set; } = string.Empty; // // اسم الطالب، مطلوب وبحد أقصى 100 حرف
//        [Required, MaxLength(20)] public string NationalId { get; set; } = string.Empty; // // رقم الهوية الوطنية
//        [Range(10, 80)] public int Age { get; set; } // // عمر الطالب (من 10 إلى 80)
//        [Required, MaxLength(20)] public string StudentNumber { get; set; } = string.Empty; // // الرقم الدراسي للطالب (رقم جامعي/معهد)

//        public bool IsActive { get; set; } = true; // // حالة الطالب (مفعل أو منسحب/متخرج)

//        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>(); // // سجلات تسجيل الطالب في المواد
//        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>(); // // سجلات حضور الطالب
//        public ICollection<Grade> Grades { get; set; } = new List<Grade>(); // // درجات الطالب في الاختبارات
//    }

//    // ================= Lecturer =================
//    public class Lecturer
//    {
//        public int Id { get; set; } // // المفتاح الأساسي للمحاضر
//        [Required, MaxLength(100)] public string Name { get; set; } = string.Empty; // // اسم المحاضر
//        [MaxLength(100)] public string? Speciality { get; set; } // // تخصص المحاضر (اختياري)

//        public ICollection<Course> Courses { get; set; } = new List<Course>(); // // المواد التي يدرّسها المحاضر
//    }

//    // ================= Course =================
//    public class Course
//    {
//        public int Id { get; set; } // // المفتاح الأساسي للمادة
//        [Required, MaxLength(100)] public string Name { get; set; } = string.Empty; // // اسم المادة
//        [Required, MaxLength(20)] public string Code { get; set; } = string.Empty; // // رمز المادة (فريد)
//        [Range(1, 10)] public int CreditHours { get; set; } // // عدد الساعات المعتمدة للمادة

//        public int? LecturerId { get; set; } // // العلاقة مع المحاضر (قد تكون فارغة لو لم يُعيّن)
//        public Lecturer? Lecturer { get; set; } // // كائن الملاحة للمحاضر المرتبط بالمادة

//        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>(); // // الطلاب المسجّلون في المادة
//        public ICollection<Exam> Exams { get; set; } = new List<Exam>(); // // اختبارات المادة
//    }

//    public enum ExamType { Midterm = 1, Final = 2, Practical = 3 } // // أنواع الاختبارات: نصفي، نهائي، عملي

//    // ================= Exam =================
//    public class Exam
//    {
//        public int Id { get; set; } // // المفتاح الأساسي للاختبار
//        public int CourseId { get; set; } // // مفتاح أجنبي يشير للمادة
//        public Course Course { get; set; } = null!; // // كائن الملاحة للمادة

//        public ExamType Type { get; set; } // // نوع الاختبار (نصفي/نهائي/عملي)
//        [Range(0, 100)] public double MaxScore { get; set; } = 100; // // الدرجة العظمى للاختبار
//        public DateTime ExamDate { get; set; } = DateTime.UtcNow; // // تاريخ الاختبار (افتراضي الآن)
//    }

//    // ===== Enrollment (Student ↔ Course) =====
//    public class Enrollment
//    {
//        public int Id { get; set; } // // المفتاح الأساسي للتسجيل
//        public int StudentId { get; set; } // // الطالب المسجَّل
//        public Student Student { get; set; } = null!; // // كائن الملاحة للطالب

//        public int CourseId { get; set; } // // المادة المسجَّل فيها
//        public Course Course { get; set; } = null!; // // كائن الملاحة للمادة

//        public DateTime EnrolledAt { get; set; } = DateTime.UtcNow; // // تاريخ التسجيل
//        public bool IsActive { get; set; } = true; // // حالة التسجيل (مفعّل)
//    }

//    // ================= Grade =================
//    public class Grade
//    {
//        public int Id { get; set; } // // المفتاح الأساسي لدرجة الطالب
//        public int StudentId { get; set; } // // الطالب
//        public Student Student { get; set; } = null!; // // كائن الملاحة للطالب

//        public int ExamId { get; set; } // // الاختبار المرتبط
//        public Exam Exam { get; set; } = null!; // // كائن الملاحة للاختبار

//        [Range(0, 100)] public double Score { get; set; } // // الدرجة التي حصل عليها الطالب
//    }

//    // ================= Attendance =================
//    public class Attendance
//    {
//        public int Id { get; set; } // // المفتاح الأساسي لسجل الحضور
//        public int StudentId { get; set; } // // الطالب
//        public Student Student { get; set; } = null!; // // كائن الملاحة للطالب

//        public int CourseId { get; set; } // // المادة
//        public Course Course { get; set; } = null!; // // كائن الملاحة للمادة

//        public DateTime Day { get; set; } = DateTime.UtcNow.Date; // // تاريخ اليوم (بدون وقت)
//        public bool Present { get; set; } // // true حاضر / false غائب
//    }
//}

//// =========================
//// DbContext
//// =========================
//namespace IMS.Data
//{
//    using IMS.Models; // // نماذج الكيانات
//    using Microsoft.EntityFrameworkCore; // // EF Core

//    public class ApplicationDbContext : DbContext
//    {
//        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { } // // تهيئة السياق بحقن الإعدادات

//        // // تعريف جداول قاعدة البيانات عبر DbSet لكل كيان
//        public DbSet<Student> Students => Set<Student>(); // // جدول الطلاب
//        public DbSet<Lecturer> Lecturers => Set<Lecturer>(); // // جدول المحاضرين
//        public DbSet<Course> Courses => Set<Course>(); // // جدول المواد
//        public DbSet<Exam> Exams => Set<Exam>(); // // جدول الاختبارات
//        public DbSet<Enrollment> Enrollments => Set<Enrollment>(); // // جدول التسجيل
//        public DbSet<Grade> Grades => Set<Grade>(); // // جدول الدرجات
//        public DbSet<Attendance> Attendances => Set<Attendance>(); // // جدول الحضور

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder); // // استدعاء التكوين الأساس

//            modelBuilder.Entity<Course>()
//                .HasIndex(c => c.Code) // // إنشاء فهرس على رمز المادة
//                .IsUnique(); // // وجعله فريدًا لمنع التكرار

//            modelBuilder.Entity<Enrollment>()
//                .HasIndex(e => new { e.StudentId, e.CourseId }) // // فهرس مركب على (طالب، مادة)
//                .IsUnique(); // // تسجيل الطالب في نفس المادة مرة واحدة فقط

//            modelBuilder.Entity<Grade>()
//                .HasIndex(g => new { g.StudentId, g.ExamId }) // // فهرس مركب على (طالب، اختبار)
//                .IsUnique(); // // يمنع إدخال أكثر من درجة لنفس (طالب+اختبار)

//            modelBuilder.Entity<Attendance>()
//                .HasIndex(a => new { a.StudentId, a.CourseId, a.Day }) // // فهرس مركب على (طالب، مادة، يوم)
//                .IsUnique(); // // يمنع تكرار سجل حضور لنفس اليوم
//        }
//    }
//}

//// =========================
//// Repository + UnitOfWork
//// =========================
//namespace IMS.Repository.Base
//{
//    using IMS.Data; // // للوصول إلى ApplicationDbContext
//    using Microsoft.EntityFrameworkCore; // // لعمليات EF Core
//    using System.Collections.Generic; // // IEnumerable
//    using System.Threading.Tasks; // // المهام غير المتزامنة async/await

//    // // واجهة المستودع العام
//    public interface IRepository<T> where T : class
//    {
//        Task<IEnumerable<T>> GetAllAsync(); // // إرجاع كل السجلات
//        Task<T?> GetByIdAsync(int id); // // إرجاع سجل حسب المعرّف
//        Task AddAsync(T entity); // // إضافة سجل جديد
//        void Update(T entity); // // تحديث سجل موجود
//        void Delete(T entity); // // حذف سجل
//        Task<int> SaveChangesAsync(); // // حفظ التغييرات فورًا (مباشرة على السياق)
//    }

//    // // تنفيذ المستودع العام عبر EF Core
//    public class Repository<T> : IRepository<T> where T : class
//    {
//        protected readonly ApplicationDbContext _ctx; // // مرجع سياق قاعدة البيانات
//        protected readonly DbSet<T> _set; // // المجموعة المقابلة للكيان T
//        public Repository(ApplicationDbContext ctx)
//        {
//            _ctx = ctx; _set = _ctx.Set<T>(); // // تهيئة السياق ومجموعة الكيان
//        }
//        public async Task<IEnumerable<T>> GetAllAsync() => await _set.AsNoTracking().ToListAsync(); // // قراءة بدون تتبع لتحسين الأداء
//        public async Task<T?> GetByIdAsync(int id) => await _set.FindAsync(id); // // إيجاد بالسجل الأساسي
//        public async Task AddAsync(T entity) { await _set.AddAsync(entity); } // // إضافة كيان جديد في الذاكرة
//        public void Update(T entity) { _set.Update(entity); } // // تعليم الكيان كمعدّل
//        public void Delete(T entity) { _set.Remove(entity); } // // تعليم الكيان كمحذوف
//        public Task<int> SaveChangesAsync() => _ctx.SaveChangesAsync(); // // حفظ التغييرات
//    }

//    using IMS.Models; // // لاستخدام كيانات المشروع

//    // // واجهة وحدة العمل لتجميع كل المستودعات
//    public interface IUnitOfWork
//    {
//        IRepository<Student> Students { get; } // // مستودع الطلاب
//        IRepository<Lecturer> Lecturers { get; } // // مستودع المحاضرين
//        IRepository<Course> Courses { get; } // // مستودع المواد
//        IRepository<Exam> Exams { get; } // // مستودع الاختبارات
//        IRepository<Enrollment> Enrollments { get; } // // مستودع التسجيلات
//        IRepository<Grade> Grades { get; } // // مستودع الدرجات
//        IRepository<Attendance> Attendances { get; } // // مستودع الحضور
//        Task<int> CompleteAsync(); // // حفظ كل التغييرات كعملية واحدة
//    }

//    // // تنفيذ وحدة العمل
//    public class UnitOfWork : IUnitOfWork
//    {
//        private readonly ApplicationDbContext _ctx; // // مرجع سياق قاعدة البيانات
//        public UnitOfWork(ApplicationDbContext ctx)
//        {
//            _ctx = ctx; // // حقن السياق
//            Students = new Repository<Student>(ctx); // // تهيئة مستودع الطلاب
//            Lecturers = new Repository<Lecturer>(ctx); // // تهيئة مستودع المحاضرين
//            Courses = new Repository<Course>(ctx); // // تهيئة مستودع المواد
//            Exams = new Repository<Exam>(ctx); // // تهيئة مستودع الاختبارات
//            Enrollments = new Repository<Enrollment>(ctx); // // تهيئة مستودع التسجيلات
//            Grades = new Repository<Grade>(ctx); // // تهيئة مستودع الدرجات
//            Attendances = new Repository<Attendance>(ctx); // // تهيئة مستودع الحضور
//        }

//        public IRepository<Student> Students { get; } // // خاصية للوصول لمستودع الطلاب
//        public IRepository<Lecturer> Lecturers { get; } // // خاصية للوصول لمستودع المحاضرين
//        public IRepository<Course> Courses { get; } // // خاصية للوصول لمستودع المواد
//        public IRepository<Exam> Exams { get; } // // خاصية للوصول لمستودع الاختبارات
//        public IRepository<Enrollment> Enrollments { get; } // // خاصية للوصول لمستودع التسجيلات
//        public IRepository<Grade> Grades { get; } // // خاصية للوصول لمستودع الدرجات
//        public IRepository<Attendance> Attendances { get; } // // خاصية للوصول لمستودع الحضور

//        public Task<int> CompleteAsync() => _ctx.SaveChangesAsync(); // // تنفيذ حفظ شامل لكل التغييرات
//    }
//}

//// =========================
//// Services: Grading & Attendance
//// =========================
//namespace IMS.Services
//{
//    using IMS.Data; // // للوصول إلى السياق
//    using IMS.Models; // // لاستخدام الكيانات
//    using Microsoft.EntityFrameworkCore; // // استعلامات EF Core
//    using System; // // أنواع عامة
//    using System.Linq; // // LINQ للاستعلام
//    using System.Threading.Tasks; // // Async/Await

//    // // واجهة خدمة حساب الدرجات والنسبة
//    public interface IGradingService
//    {
//        Task<double> GetCoursePercentageAsync(int studentId, int courseId); // // نسبة الطالب في مادة
//        Task<double> GetGPAAsync(int studentId); // // المعدل العام للطالب (مثال مبسّط)
//    }

//    // // تنفيذ خدمة الدرجات
//    public class GradingService : IGradingService
//    {
//        private readonly ApplicationDbContext _ctx; // // مرجع السياق
//        public GradingService(ApplicationDbContext ctx) => _ctx = ctx; // // تهيئة عبر الحقن

//        // // يحسب نسبة الطالب في مادة بجمع درجاته على مجموع الدرجات العظمى لكل اختبارات المادة
//        public async Task<double> GetCoursePercentageAsync(int studentId, int courseId)
//        {
//            var exams = await _ctx.Exams.Where(e => e.CourseId == courseId).ToListAsync(); // // جلب اختبارات المادة
//            if (exams.Count == 0) return 0.0; // // لا يوجد اختبارات

//            var examIds = exams.Select(e => e.Id).ToList(); // // استخراج معرفات الاختبارات
//            var grades = await _ctx.Grades.Where(g => g.StudentId == studentId && examIds.Contains(g.ExamId)).ToListAsync(); // // جلب درجات الطالب لهذه الاختبارات

//            double totalWeight = exams.Sum(e => e.MaxScore); // // مجموع الدرجات العظمى
//            if (totalWeight == 0) return 0.0; // // حماية من القسمة على صفر

//            double earned = grades.Sum(g => g.Score); // // مجموع الدرجات التي حصل عليها
//            return Math.Round((earned / totalWeight) * 100.0, 2); // // تحويل للنسبة المئوية مع التقريب
//        }

//        // // مثال مبسّط لتحويل النسبة إلى مقياس 5.0 (يمكن تعديل السياسة)
//        public async Task<double> GetGPAAsync(int studentId)
//        {
//            var studentCourses = await _ctx.Enrollments
//                                    .Where(e => e.StudentId == studentId && e.IsActive)
//                                    .Select(e => e.CourseId).ToListAsync(); // // جلب مواد الطالب النشطة
//            if (studentCourses.Count == 0) return 0.0; // // لا توجد مواد

//            double sum = 0; int count = 0; // // تجميع قيم GPA
//            foreach (var courseId in studentCourses) // // لكل مادة مسجلة
//            {
//                var pct = await GetCoursePercentageAsync(studentId, courseId); // // حساب نسبة المادة
//                double g = pct switch // // تحويل النسبة إلى GPA وفق سياسة بسيطة
//                {
//                    >= 95 => 5.0,
//                    >= 90 => 4.75,
//                    >= 85 => 4.5,
//                    >= 80 => 4.25,
//                    >= 75 => 4.0,
//                    >= 70 => 3.5,
//                    >= 65 => 3.0,
//                    >= 60 => 2.5,
//                    _ => 2.0
//                };
//                sum += g; count++; // // جمع المعدلات وحساب العدد
//            }
//            return Math.Round(sum / count, 2); // // المتوسط العام مع التقريب
//        }
//    }

//    // // واجهة خدمة الحضور
//    public interface IAttendanceService
//    {
//        Task<(int presentDays, int totalDays, double attendancePct, double deprivationPct)> GetAttendanceAsync(int studentId, int courseId); // // إحصاءات حضور الطالب
//    }

//    // // تنفيذ خدمة الحضور
//    public class AttendanceService : IAttendanceService
//    {
//        private readonly ApplicationDbContext _ctx; // // مرجع السياق
//        public AttendanceService(ApplicationDbContext ctx) => _ctx = ctx; // // تهيئة عبر الحقن

//        // // إرجاع: أيام الحضور، إجمالي الأيام، نسبة الحضور، نسبة الحرمان (غياب/إجمالي)
//        public async Task<(int presentDays, int totalDays, double attendancePct, double deprivationPct)> GetAttendanceAsync(int studentId, int courseId)
//        {
//            var records = await _ctx.Attendances
//                .Where(a => a.StudentId == studentId && a.CourseId == courseId)
//                .ToListAsync(); // // جلب سجلات حضور الطالب في المادة
//            int total = records.Count; // // إجمالي السجلات
//            if (total == 0) return (0, 0, 0, 0); // // لا توجد سجلات

//            int present = records.Count(r => r.Present); // // عدد أيام الحضور
//            int absent = total - present; // // عدد أيام الغياب
//            double attendancePct = Math.Round((present / (double)total) * 100.0, 2); // // نسبة الحضور
//            double deprivationPct = Math.Round((absent / (double)total) * 100.0, 2); // // نسبة الحرمان
//            return (present, total, attendancePct, deprivationPct); // // إرجاع الإحصاءات
//        }
//    }
//}

//// =========================
//// Controllers (CRUD + عمليات أساسية)
//// =========================
//namespace IMS.Controllers
//{
//    using IMS.Data; // // السياق للقراءات المعقّدة (Include)
//    using IMS.Models; // // الكيانات
//    using IMS.Repository.Base; // // وحدة العمل والمستودعات
//    using IMS.Services; // // الخدمات (درجات/حضور)
//    using Microsoft.AspNetCore.Mvc; // // MVC
//    using Microsoft.EntityFrameworkCore; // // Include/LINQ
//    using System.Linq; // // استعلامات LINQ
//    using System.Threading.Tasks; // // Async/Await

//    // ================= StudentsController =================
//    [Route("[controller]/[action]")]
//    public class StudentsController : Controller
//    {
//        private readonly IUnitOfWork _uow; // // وحدة العمل للوصول للمستودعات
//        private readonly IGradingService _grading; // // خدمة الدرجات
//        private readonly IAttendanceService _attendance; // // خدمة الحضور
//        public StudentsController(IUnitOfWork uow, IGradingService grading, IAttendanceService attendance)
//        { _uow = uow; _grading = grading; _attendance = attendance; } // // حقن التبعيات عبر المُنشئ

//        [HttpGet]
//        public async Task<IActionResult> Index()
//        {
//            var list = await _uow.Students.GetAllAsync(); // // جلب جميع الطلاب
//            return View(list); // // عرضهم في الواجهة
//        }

//        [HttpGet("{id:int}")]
//        public async Task<IActionResult> Details(int id)
//        {
//            var s = await _uow.Students.GetByIdAsync(id); // // جلب طالب محدد
//            if (s is null) return NotFound(); // // إن لم يوجد، أعد 404
//            return View(s); // // عرض تفاصيل الطالب
//        }

//        [HttpGet]
//        public IActionResult Create() => View(); // // عرض نموذج إنشاء طالب

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create(Student model)
//        {
//            if (!ModelState.IsValid) return View(model); // // التحقق من صحة البيانات
//            await _uow.Students.AddAsync(model); // // إضافة الطالب
//            await _uow.CompleteAsync(); // // حفظ التغييرات
//            return RedirectToAction(nameof(Index)); // // الرجوع لقائمة الطلاب
//        }

//        [HttpGet("{id:int}")]
//        public async Task<IActionResult> Edit(int id)
//        {
//            var s = await _uow.Students.GetByIdAsync(id); // // جلب الطالب المطلوب تعديله
//            if (s is null) return NotFound(); // // إن لم يوجد
//            return View(s); // // عرض النموذج بالبيانات
//        }

//        [HttpPost("{id:int}")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, Student model)
//        {
//            if (id != model.Id) return BadRequest(); // // حماية من تلاعب المعرف
//            if (!ModelState.IsValid) return View(model); // // التحقق من صحة البيانات
//            _uow.Students.Update(model); // // تحديث الطالب
//            await _uow.CompleteAsync(); // // حفظ
//            return RedirectToAction(nameof(Index)); // // رجوع للقائمة
//        }

//        [HttpGet("{id:int}")]
//        public async Task<IActionResult> Delete(int id)
//        {
//            var s = await _uow.Students.GetByIdAsync(id); // // جلب الطالب
//            if (s is null) return NotFound(); // // في حال عدم وجوده
//            return View(s); // // صفحة تأكيد الحذف
//        }

//        [HttpPost("{id:int}")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var s = await _uow.Students.GetByIdAsync(id); // // جلب الطالب مرة أخرى
//            if (s is null) return NotFound(); // // حماية
//            _uow.Students.Delete(s); // // حذف الطالب
//            await _uow.CompleteAsync(); // // حفظ التغييرات
//            return RedirectToAction(nameof(Index)); // // العودة للقائمة
//        }

//        // // إرجاع نسبة الطالب في مادة (للداشبورد أو واجهات AJAX)
//        [HttpGet("{studentId:int}/{courseId:int}")]
//        public async Task<IActionResult> CoursePercentage(int studentId, int courseId)
//        {
//            var pct = await _grading.GetCoursePercentageAsync(studentId, courseId); // // حساب النسبة
//            return Ok(new { studentId, courseId, percentage = pct }); // // إرجاع JSON
//        }

//        // // إرجاع المعدل العام GPA لواجهة الطالب
//        [HttpGet("{studentId:int}")]
//        public async Task<IActionResult> GPA(int studentId)
//        {
//            var gpa = await _grading.GetGPAAsync(studentId); // // حساب GPA
//            return Ok(new { studentId, gpa }); // // إرجاع JSON
//        }

//        // // إحصاءات الحضور والحرمان للمادة
//        [HttpGet("{studentId:int}/{courseId:int}")]
//        public async Task<IActionResult> AttendanceStats(int studentId, int courseId)
//        {
//            var (present, total, attendancePct, deprivationPct) = await _attendance.GetAttendanceAsync(studentId, courseId); // // حساب الإحصاءات
//            return Ok(new { studentId, courseId, present, total, attendancePct, deprivationPct }); // // إرجاع JSON
//        }
//    }

//    // ================= LecturersController (مختصر مع تعليقات) =================
//    [Route("[controller]/[action]")]
//    public class LecturersController : Controller
//    {
//        private readonly IUnitOfWork _uow; // // وحدة العمل
//        public LecturersController(IUnitOfWork uow) { _uow = uow; } // // حقن عبر المُنشئ

//        [HttpGet] public async Task<IActionResult> Index() => View(await _uow.Lecturers.GetAllAsync()); // // قائمة المحاضرين
//        [HttpGet("{id:int}")] public async Task<IActionResult> Details(int id) => (await _uow.Lecturers.GetByIdAsync(id)) is { } l ? View(l) : NotFound(); // // تفاصيل
//        [HttpGet] public IActionResult Create() => View(); // // نموذج إنشاء
//        [HttpPost][ValidateAntiForgeryToken] public async Task<IActionResult> Create(Lecturer m) { if (!ModelState.IsValid) return View(m); await _uow.Lecturers.AddAsync(m); await _uow.CompleteAsync(); return RedirectToAction(nameof(Index)); } // // إضافة وحفظ
//        [HttpGet("{id:int}")] public async Task<IActionResult> Edit(int id) => (await _uow.Lecturers.GetByIdAsync(id)) is { } l ? View(l) : NotFound(); // // تعديل
//        [HttpPost("{id:int}")][ValidateAntiForgeryToken] public async Task<IActionResult> Edit(int id, Lecturer m) { if (id != m.Id) return BadRequest(); if (!ModelState.IsValid) return View(m); _uow.Lecturers.Update(m); await _uow.CompleteAsync(); return RedirectToAction(nameof(Index)); } // // تحديث وحفظ
//        [HttpGet("{id:int}")] public async Task<IActionResult> Delete(int id) => (await _uow.Lecturers.GetByIdAsync(id)) is { } l ? View(l) : NotFound(); // // حذف (تأكيد)
//        [HttpPost("{id:int}")][ValidateAntiForgeryToken] public async Task<IActionResult> DeleteConfirmed(int id) { var l = await _uow.Lecturers.GetByIdAsync(id); if (l is null) return NotFound(); _uow.Lecturers.Delete(l); await _uow.CompleteAsync(); return RedirectToAction(nameof(Index)); } // // تنفيذ الحذف
//    }

//    // ================= CoursesController (أبرز الأسطر) =================
//    [Route("[controller]/[action]")]
//    public class CoursesController : Controller
//    {
//        private readonly ApplicationDbContext _ctx; // // لاستخدام Include
//        private readonly IUnitOfWork _uow; // // وحدة العمل
//        public CoursesController(ApplicationDbContext ctx, IUnitOfWork uow) { _ctx = ctx; _uow = uow; } // // حقن

//        [HttpGet]
//        public async Task<IActionResult> Index()
//        {
//            var data = await _ctx.Courses.Include(c => c.Lecturer).ToListAsync(); // // جلب المواد مع المحاضر
//            return View(data); // // عرضها
//        }

//        [HttpGet("{id:int}")]
//        public async Task<IActionResult> Details(int id)
//        {
//            var item = await _ctx.Courses.Include(c => c.Lecturer).FirstOrDefaultAsync(c => c.Id == id); // // مادة واحدة بالتفاصيل
//            return item is null ? NotFound() : View(item); // // إظهار أو 404
//        }

//        [HttpGet] public IActionResult Create() => View(); // // نموذج إنشاء
//        [HttpPost][ValidateAntiForgeryToken] public async Task<IActionResult> Create(Course m) { if (!ModelState.IsValid) return View(m); await _uow.Courses.AddAsync(m); await _uow.CompleteAsync(); return RedirectToAction(nameof(Index)); } // // إضافة وحفظ
//        [HttpGet("{id:int}")] public async Task<IActionResult> Edit(int id) { var m = await _uow.Courses.GetByIdAsync(id); return m is null ? NotFound() : View(m); } // // تحميل للتعديل
//        [HttpPost("{id:int}")][ValidateAntiForgeryToken] public async Task<IActionResult> Edit(int id, Course m) { if (id != m.Id) return BadRequest(); if (!ModelState.IsValid) return View(m); _uow.Courses.Update(m); await _uow.CompleteAsync(); return RedirectToAction(nameof(Index)); } // // تحديث
//        [HttpGet("{id:int}")] public async Task<IActionResult> Delete(int id) { var m = await _uow.Courses.GetByIdAsync(id); return m is null ? NotFound() : View(m); } // // تأكيد حذف
//        [HttpPost("{id:int}")][ValidateAntiForgeryToken] public async Task<IActionResult> DeleteConfirmed(int id) { var m = await _uow.Courses.GetByIdAsync(id); if (m is null) return NotFound(); _uow.Courses.Delete(m); await _uow.CompleteAsync(); return RedirectToAction(nameof(Index)); } // // تنفيذ الحذف
//    }
//}

//// =========================
//// Program.cs (DI wiring) — مع شرح بالعربي
//// =========================
///*
//using IMS.Data; // // مساحة الأسماء للسياق
//using IMS.Repository.Base; // // وحدة العمل والمستودعات
//using IMS.Services; // // الخدمات (درجات/حضور)
//using Microsoft.EntityFrameworkCore; // // مزود EF Core

//var builder = WebApplication.CreateBuilder(args); // // إنشاء البيلدر للتطبيق

//builder.Services.AddControllersWithViews(); // // تفعيل MVC والواجهات

//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // // ربط EF Core بقاعدة بيانات SQL Server عبر سلسلة الاتصال

//builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(); // // تسجيل وحدة العمل بنطاق Scoped
//builder.Services.AddScoped<IGradingService, GradingService>(); // // تسجيل خدمة الدرجات
//builder.Services.AddScoped<IAttendanceService, AttendanceService>(); // // تسجيل خدمة الحضور

//var app = builder.Build(); // // بناء التطبيق

//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error"); // // صفحة خطأ عامة في الإنتاج
//    app.UseHsts(); // // تفعيل HSTS
//}

//app.UseHttpsRedirection(); // // إعادة التوجيه لـ HTTPS
//app.UseStaticFiles(); // // تمكين الملفات الثابتة (CSS/JS/صور)
//app.UseRouting(); // // تفعيل التوجيه
//app.UseAuthorization(); // // (اختياري) لو عندك هوية وصلاحيات

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Students}/{action=Index}/{id?}"); // // المسار الافتراضي للتطبيق

//app.Run(); // // تشغيل التطبيق
//*/

//// =============================================================
//// انتهت النسخة المشروحة
//// =============================================================
