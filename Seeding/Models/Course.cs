using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seeding.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public Customer customer { get; set; }
    }
}