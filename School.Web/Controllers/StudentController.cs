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
            DataAccess.Read<Student>().ForEach(student=> students.Add(new StudentViewModel(student)));
            ViewBag.StudentList = students;
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(int PersonId, int ClassId)
        {
            //var person = new Person()
            //{
            //    Prefix = Prefix,
            //    FirstName = FirstName,
            //    MiddleName = MiddleName,
            //    LastName = LastName,
            //    BirthDay = BirthDay.ToString()
            //};
            //var persons = DataAccess.Read<Person>();
            //person.Id = persons.Count > 0 ? persons.OrderByDescending(l => l.Id).FirstOrDefault().Id + 1 : 1;
            //persons.Add(person);
            //DataAccess.Write(persons);
            return View();
        }
    }
}