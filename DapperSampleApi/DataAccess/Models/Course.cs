using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperSampleApi.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public virtual ICollection<Student> Students{ get; set; }
    }
}