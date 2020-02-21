using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDManagement.Models
{
    public enum Dept
    {
        IT, Accounts, Insurance, HealthCare
    }
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public Dept Dept { get; set; }
    }

}
