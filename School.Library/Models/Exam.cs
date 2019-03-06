using System;
using System.Collections.Generic;
using System.Linq;

namespace School.Library.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int LessonId { get; set; }
        public decimal Score { get; set; }
        public DateTime Date { get; set; }
        public DateTime AnnouncementDate { get; set; }
        public DateTime ClarificationDate { get; set; }

        public override string ToString()
        {
            return $"{Id} :StudentId: {StudentId} LessonId: {LessonId} Score: {Score}";
        }
    }
}