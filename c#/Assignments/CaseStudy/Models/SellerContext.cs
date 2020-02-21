using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace CaseStudy.Models
{
    public class SellerContext:DbContext
    {
        public SellerContext(DbContextOptions<SellerContext> options) : base(options)
        {

        }
        public DbSet<Seller> sellers { get; set; }
    }
}
