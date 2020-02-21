using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    public class EmployeeProjectViewModel
    {//view model class to help in taking data from multiple sources
        public Employee1 employee { get; set; }
        public string projectName;
    }
}
