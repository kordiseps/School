using School.Library.Models;
using School.Library.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Web.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            var persons = DataAccess.Read<Person>();
            ViewBag.PersonList = persons;
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string Prefix, string FirstName, string MiddleName, string LastName, DateTime BirthDay)
        {
            var person = new Person()
            {
                Prefix = Prefix,
                FirstName = FirstName,
                MiddleName = MiddleName,
                LastName = LastName,
                BirthDay = BirthDay.ToString()
            };
            var persons = DataAccess.Read<Person>();
            person.Id = persons.Count > 0 ? persons.OrderByDescending(l => l.Id).FirstOrDefault().Id + 1 : 1;
            persons.Add(person);
            DataAccess.Write(persons);
            return View();
        }
    }
}