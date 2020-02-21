using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CaseStudy.Models
{
    public class SellerViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public long MobileNo { get; set; }
        public string Companyname { get; set; }
        public string BriefabtCompany { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public int GSTIN { get; set; }
        public IFormFile PhotoPath { get; set; }

    }
}
