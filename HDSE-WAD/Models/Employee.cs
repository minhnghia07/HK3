using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HDSE_WAD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your department")]
        public string Department { get; set; }
        [Required(ErrorMessage = "Please enter your salary")]
        public int Salary { get; set; }

    }
}