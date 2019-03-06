using System;
using System.Collections.Generic;
using System.Linq;

namespace School.Library.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string BirthDay { get; set; }

        public override string ToString()
        {
            return $"{Id} : {Prefix} {FirstName} {MiddleName} {LastName}";
        }
    }
}