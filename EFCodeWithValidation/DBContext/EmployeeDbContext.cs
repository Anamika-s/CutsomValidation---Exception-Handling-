using EFCodeWithValidation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFCodeWithValidation.DBContext
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        //public EmployeeDbContext() :base ("test")
        //{

        //}
    }
}