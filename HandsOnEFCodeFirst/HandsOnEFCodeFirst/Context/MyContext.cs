using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HandsOnEFCodeFirst.Models;

namespace HandsOnEFCodeFirst.Context
{
    class MyContext:DbContext
    {
        //define entities
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Define connection string
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-L2GAA57\SQLEXPRESS;Initial Catalog=StudentDB;Persist Security Info=True;User ID=sa;Password=pass@word1");

        }
    }
}
