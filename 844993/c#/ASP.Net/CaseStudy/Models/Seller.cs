using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudy
{
    public class Seller
    {
        public string name, password, emailid, companyname, briefabtcmpy, address, website;
        public int mobileno, GST,id;
        public Seller(string name, string password, string emailid, int mobileno, string companyname, string briefabtcmpy, string address, string website, int GST,int id)
        {
            this.name = name;
            this.password = password;
            this.emailid = emailid;
            this.mobileno = mobileno;
            this.companyname = companyname;
            this.briefabtcmpy = briefabtcmpy;
            this.address = address;
            this.website = website;
            this.GST = GST;
            this.id = id;
        }
    }
}
