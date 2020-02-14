using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFDALAssign.Models
{
    [Table("Item")]
   public class Item
    {
        [Key]
        public int ItemID { get; set; }
        [Required]
        [StringLength(30)]
        public string ItemName { get; set; }
        public int? Price { get; set; }
        public IEnumerable<order> orders { get; set; }
    }
}
