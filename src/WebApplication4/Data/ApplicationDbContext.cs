﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
//using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4.Data
{   
    public class ApplicationDbContext : IdentityDbContext
    {
        //private object modelBuilder;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<DegreeCredit> DegreeCredits { get; set; }
        public DbSet<DegreePlan> DegreePlans { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Student> StudentTerms { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Credit>().ToTable("Credits");
            modelBuilder.Entity<Degree>().ToTable("Degrees");
            modelBuilder.Entity<DegreeCredit>().ToTable("DegreeCredits");
            modelBuilder.Entity<DegreePlan>().ToTable("DegreePlans");
            modelBuilder.Entity<Slot>().ToTable("Slots");
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<StudentTerm>().ToTable("StudentTerms");

        }


    }
    
}
