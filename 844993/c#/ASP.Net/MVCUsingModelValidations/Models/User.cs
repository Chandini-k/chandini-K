using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVCUsingModelValidations.Models
{
    public class User
    {
        [Required(ErrorMessage = "pls Enter Name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Name should be greater than 4")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="Invalid email address")]
        public string Email { get; set; }
        //[Required(ErrorMessage ="Enter DOB")]
        public DateTime DOB { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Invalid Number")]
        public string Mobileno { get; set; }
        //[Required(ErrorMessage ="Enter Country")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Pls Select Country")]
        public string Country { get; set; }
        [Required(ErrorMessage ="UserName Required")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [RegularExpression("[a-z0-9]{6,8}",ErrorMessage ="Invalid")]
        public string Pwd { get; set; }

    }
}
