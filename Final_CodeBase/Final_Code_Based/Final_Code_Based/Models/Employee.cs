using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Code_Based.Models
{
    public class Employee
    {
        [Key]
        public int  EmployeeId{get;set;}
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
      
        public float Salary { get; set; }
        public string Job { get; set; }

    }
}
