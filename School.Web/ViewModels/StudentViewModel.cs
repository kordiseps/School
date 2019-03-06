using School.Library.Models;
using School.Library.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.Web.ViewModels
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string PersonName { get; set; }
        public string ClassName { get; set; }
        public StudentViewModel(Student student)
        {
            var _person = DataAccess.Read<Person>().FirstOrDefault(p=>p.Id == student.PersonId);
            var _class = DataAccess.Read<Class>().FirstOrDefault(p=>p.Id == student.ClassId);
            PersonName = $"{_person.Prefix} {_person.FirstName} {_person.MiddleName} {_person.LastName}";
            ClassName = $"{_class.Grade}-{_class.Branch}";
            StudentId = student.Id;
        }

    }
}