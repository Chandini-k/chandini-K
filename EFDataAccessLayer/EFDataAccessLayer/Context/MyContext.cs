using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EFDataAccessLayer.Models;

namespace EFDataAccessLayer.Context
{
    public class MyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-L2GAA57\SQLEXPRESS;Initial Catalog=EMSDB;Persist Security Info=True;User ID=sa;Password=pass@word1");
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
