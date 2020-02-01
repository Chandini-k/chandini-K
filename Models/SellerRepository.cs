using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudy.Models
{
    public class SellerRepository
    {
        public List<Seller> slist;
        public SellerRepository()
        {
            slist = new List<Seller>() { new Seller("Ajay","12345678","abcd@gmail.com",12132493,"cts","asdffd","rdges","rfgvrer",24234,1),
                new Seller("ram","12345678","abcd@gmail.com",436362234,"cts","asdffd","rdges","rfgvrer",24534,2),
            new Seller("cherry","12345678","abcd@gmail.com",563425235,"cts","asdffd","rdges","rfgvrer",24234,3)};
        }
        public Seller GetSeller(int id)
        {
            Seller e = slist.FirstOrDefault(e => e.id== id);
            return e;
        }
        public List<Seller> DisplayDetails()
        {
            return slist;
        }
    }
}
