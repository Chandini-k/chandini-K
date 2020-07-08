﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCOREDBFirst.Models
{
    public partial class PracticeDBContext : DbContext
    {
        public PracticeDBContext()
        {
        }

        public PracticeDBContext(DbContextOptions<PracticeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Project> Project { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-L2GAA57\\SQLEXPRESS;Initial Catalog=PracticeDB;Persist Security Info=True;User ID=sa;Password=pass@word1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__Employee__D9509F6D4B51F84D");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Designation)
                    .HasColumnName("designation")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Joindate)
                    .HasColumnName("joindate")
                    .HasColumnType("date");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("FK__Employee__pid__15502E78");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__product__DD37D91AD5B59763");

                entity.ToTable("product");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__project__DD37D91AB030CA08");

                entity.ToTable("project");

                entity.HasIndex(e => e.Pname)
                    .HasName("UQ__project__1FC9734CA8C9BD21")
                    .IsUnique();

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Edate)
                    .HasColumnName("edate")
                    .HasColumnType("date");

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasColumnName("pname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sdate)
                    .HasColumnName("sdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}