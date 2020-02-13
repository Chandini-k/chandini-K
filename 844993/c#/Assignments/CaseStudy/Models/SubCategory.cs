using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CaseStudy.Models
{
    public class SubCategory:Category
    {
        [Key]
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string Briefdetails { get; set; }
        public int GST { get; set; }
        public SubCategory(int subcategory_id, string subcategory_name, string brief_details, int GST, int category_id, string category_name) :
            base(category_id, category_name, brief_details)
        {
            this.SubCategoryId = subcategory_id;
            this.SubCategoryName = subcategory_name;
            this.Briefdetails = brief_details;
            this.GST = GST;
        }
    }
}
