using System;
using System.Collections.Generic;
using System.Linq;

namespace School.Library.Models
{
    public class Student 
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int ClassId { get; set; }

        //public override string ToString()
        //{
        //    return $"{base.ToString()} ({Class.ToString()}) ";
        //}
    }
}