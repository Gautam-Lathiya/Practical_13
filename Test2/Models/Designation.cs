using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test2.Models
{
    public class Designation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string DesignationName { get; set; }

        // Navigation property
        public virtual ICollection<Employee> Employees { get; set; }
    }
}