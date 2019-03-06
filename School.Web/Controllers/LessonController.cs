using School.Library.Models;
using School.Library.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Web.Controllers
{
    public class LessonController : Controller
    {
        public ActionResult Index()
        {
            var lessons = DataAccess.Read<Lesson>();
            ViewBag.LessonList = lessons;
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string Name, string Description)
        {
            var lesson = new Lesson();
            lesson.Name = Name;
            lesson.Description = Description;
            lesson.Average = 0;
            var lessons = DataAccess.Read<Lesson>();
            lesson.Id = lessons.Count > 0 ? lessons.OrderByDescending(l => l.Id).FirstOrDefault().Id + 1 : 1;
            lessons.Add(lesson);
            DataAccess.Write(lessons);
            return View();
        }
    }
}