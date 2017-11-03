using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seeding.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("name=CustomerContext")
        { }
        public DbSet<Customer> CustomerList { get; set; }
        public DbSet<Course> CourseList { get; set; }

    }
}