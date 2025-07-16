using StudentEntryForm.Models;
using System.Web.Mvc;

namespace StudentEntryForm.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            return View(new Studentt());
        }

        [HttpPost]
        public ActionResult Index(Studentt model)
        {
            if (ModelState.IsValid)
            {
                StudentDataDataContext db = new StudentDataDataContext();
                db.Students.InsertOnSubmit(model);
                db.SubmitChanges();

                ViewBag.Message = "Student record saved successfully!";
                ModelState.Clear();
                return View(new Studentt());
            }

            return View(model);
        }
    }
}
