using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFCodeWithValidation.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string EmployeeCode { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        [Range(12000, 25000)]
        public int Salary { get; set; }
        [DataType(DataType.Date)]
        [MoreThanCurrentDate]
        public  DateTime JoiningDate { get; set; }
        [CheckDateRangeAttribute]
        public int Age { get; set; }
    }
}