using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Test1.Models;

namespace Test1.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("EmployeeConnection") { }

        public DbSet<Employee> Employees { get; set; }
    }
}