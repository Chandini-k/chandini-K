using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFDataAccessLayer.Models
{
    [Table("Project")]
   public class Project
    {
        [Key]//set primary key
        public int ProjectID { get; set; }
        [Required]
        [StringLength(30)]
        public string ProjectName { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? EndDate { get; set; }
        //set one to many relation with employee
        public IEnumerable<Employee> Employees { get; set; }

    }
}
