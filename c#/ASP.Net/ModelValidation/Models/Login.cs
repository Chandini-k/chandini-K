using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ModelValidation.Models
{
    public class Login
    {
        [Required(ErrorMessage="Username is Required")]//if the property value is required compulsory
        [DisplayName("Username")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [DisplayName("Password")]
        public string Pwd { get; set; }
    }
}
