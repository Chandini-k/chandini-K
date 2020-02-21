using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCOREDBFirst.Models
{
    public partial class Product
    {
        [Key]
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int? Price { get; set; }
        public int? Stock { get; set; }
    }
}
