using School.Library.Models;
using School.Library.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Web.Controllers
{
    public class ClassController : Controller
    {
        public ActionResult Index()
        {
            var classes = DataAccess.Read<Class>();
            ViewBag.ClassList = classes;
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string Branch, int Grade)
        {
            var newclass = new Class()
            {
                Branch= string.IsNullOrEmpty(Branch)?'-': Branch[0],
                Grade= Grade
            };
           
            var classes = DataAccess.Read<Class>();
            newclass.Id = classes.Count > 0 ? classes.OrderByDescending(l => l.Id).FirstOrDefault().Id + 1 : 1;
            classes.Add(newclass);
            DataAccess.Write(classes);
            return View();
        }
    }
}