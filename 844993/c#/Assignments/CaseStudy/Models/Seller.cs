using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CaseStudy.Models
{
    public class Seller
    {
        [Key]
        public int Sid { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Length can be Maximum 10")]

        public string UserName { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [RegularExpression("[a-z0-9]{6,8}", ErrorMessage = "Invalid")]
        public string Password { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [RegularExpression("^([a-zA-Z0-9]+)@([a-zA-Z0-9]+)\\.([a-zA-Z]{2,5})$", ErrorMessage = "Invalid")]
        public string Email { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Invalid Number")]
        public long MobileNo { get; set; }
        [Required(ErrorMessage = "Companyname Required")]
        public string Companyname { get; set; }
        [Required(ErrorMessage = "BriefabtCompany Required")]
        public string BriefabtCompany { get; set; }
        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Website Required")]
        public string Website { get; set; }
        [Required(ErrorMessage = "GSTIN Required")]
        public int GSTIN { get; set; }
        public string PhotoPath { get; set; }

        public Seller()
        {

        }

    }
}
