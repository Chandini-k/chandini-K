using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CaseStudy.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public float Price { get; set; }
        public string Item_Name { get; set; }
        public string Description { get; set; }
        public int Stocknumber {get;set;}
        public string Remarks { get; set; }
        public Item()
        {

        }
    }
}
