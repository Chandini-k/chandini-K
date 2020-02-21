using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EFDALAssign.Models;

namespace EFDALAssign.Context
{
    public class MyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-L2GAA57\SQLEXPRESS;Initial Catalog=ItemDB;Persist Security Info=True;User ID=sa;Password=pass@word1");
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<order> Orders { get; set; }
    }
}
