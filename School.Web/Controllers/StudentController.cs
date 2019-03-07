using School.Library.Models;
using School.Library.Work;
using School.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Web.Controllers
{
    public class StudentController : Controller
    {
        //public int Id { get; set; }
        //public int PersonId { get; set; }
        //public int ClassId { get; set; }

        public ActionResult Index()
        {
            var students = new List<StudentViewModel>();
            var studentsFromDB = DataAccess.Read<Student>();
            if (studentsFromDB!= null && studentsFromDB.Count>0)
            {
                studentsFromDB.ForEach(student => students.Add(new StudentViewModel(student)));
            }
            ViewBag.StudentList = students;
            return View();
        }
        public ActionResult Create()
        {
            var persons =  DataAccess.Read<Person>().Select(c => new KeyValuePair<int, string>(c.Id, $"{c.FirstName} {c.MiddleName} {c.LastName}")).ToList();
            var classes = DataAccess.Read<Class>().Select(c => new KeyValuePair<int, string>(c.Id, $"{c.Grade}-{c.Branch}")).ToList();
            ViewBag.PersonList = persons;
            ViewBag.ClassList = classes;
            return View();
        }

        [HttpPost]
        public ActionResult Create(int PersonId, int ClassId)
        {
            var student = new Student()
            {
                ClassId=ClassId,
                PersonId=PersonId
            };
            var students = DataAccess.Read<Student>();
            student.Id = students.Count > 0 ? students.OrderByDescending(l => l.Id).FirstOrDefault().Id + 1 : 1;
            students.Add(student);
            DataAccess.Write(students);
            return RedirectToAction("Index");
        }
    }
}