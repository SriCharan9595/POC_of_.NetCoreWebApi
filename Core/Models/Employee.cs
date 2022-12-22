using System;
using System.ComponentModel.DataAnnotations;

namespace AzureFuncApi.Core.Models
{
    public class Employee
    {
        [Key]
        [Display(Name = "Employee ID")]
        public int empID { get; set; }

        [Required(ErrorMessage = "Name is mandatory")]
        public string empName { get; set; }

        public int empAge { get; set; }

        public string empLn { get; set; }

    }
}

