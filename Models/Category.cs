using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CaseStudy.Models
{
    public class Category
    {
        [Key]
        public int Categoryid { get; set; }
        public string Categoryname { get; set; }
        public string BriefDetails { get; set; }

    }
}
