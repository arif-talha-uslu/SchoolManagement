using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Models.Contexts;
using SchoolManagement.Models.Entities;
using System.Linq;

namespace SchoolManagement.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentsList()
        {
            using (var db = new SchoolContext())
            {
                var students = db.Students.ToList();
                return View(students);
            }
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            using (var db = new SchoolContext())
            {
                db.Students.Add(student);
                db.SaveChanges();

                return View("StudentsList", db.Students.ToList());
            }
        }

        [HttpPost]
        public IActionResult DeleteStudent(int id)
        {
            using (var db = new SchoolContext())
            {
                try
                {
                    var studentwillbedeleted = db.Students.Find(id);
                    db.Students.Remove(studentwillbedeleted);
                    db.SaveChanges();
                }
                catch (System.Exception)
                {
                    return RedirectToAction("StudentsList", db.Students.ToList());
                }

                return RedirectToAction("StudentsList", db.Students.ToList());
            }
        }
    }
}
