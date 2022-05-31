using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Models.Contexts;
using SchoolManagement.Models.Entities;
using System.Linq;

namespace SchoolManagement.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult TeachersList()
        {
            using (var db = new SchoolContext())
            {
                var teachers = db.Teachers.ToList();
                return View(teachers);
            }
        }

        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {
            using (var db = new SchoolContext())
            {
                db.Teachers.Add(teacher);
                db.SaveChanges();

                return View("TeachersList", db.Teachers.ToList());
            }
        }

        [HttpPost]
        public IActionResult DeleteTeacher(int id)
        {
            using (var db = new SchoolContext())
            {
                try
                {
                    var teacherwillbedeleted = db.Teachers.Find(id);
                    db.Teachers.Remove(teacherwillbedeleted);
                    db.SaveChanges();
                }
                catch (System.Exception)
                {
                    return RedirectToAction("TeachersList", db.Teachers.ToList());
                }

                return RedirectToAction("TeachersList", db.Teachers.ToList());
            }
        }
    }
}
