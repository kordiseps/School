using System;
using System.Collections.Generic;
using System.Linq;

namespace School.Library.Models
{
    public class Class
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        public char Branch { get; set; }
        public override string ToString()
        {
            return $"{Id} : {Grade} - {Branch}";
        }
    }
}