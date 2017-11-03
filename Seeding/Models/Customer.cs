using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seeding.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Plz enter valid Name")]
        [StringLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Plz enter valid Location")]
        [StringLength(20)]
        public string Location { get; set; }

        [Required(ErrorMessage = "Plz enter valid Phone")]
        [StringLength(20)]
        public int Phone { get; set; }

        [Required(ErrorMessage = "Plz enter valid Email")]
        [StringLength(20)]
        public string Email { get; set; }
        public virtual ICollection<Course> course { get; set; }
    }
}