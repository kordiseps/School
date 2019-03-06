using System;
using System.Collections.Generic;
using System.Linq;

namespace School.Library.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Average { get; set; }

        public override string ToString()
        {
            return $"{Id} : {Name} ({Description}) - {Average}";
        }
    }
}