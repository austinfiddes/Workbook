﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new SchoolContext())
            {
                int count = context.Courses.Count();
                Console.WriteLine($"There are {count} courses");
            }
        }
    }
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolDb")
        {

        }
        public DbSet<Course> Courses { get; set; }
    }
    [Table("Courses")]
    public class Course
    {
        public int CourseID { get; set; } // EF will accept this as a PK, by its default convention

        [Required]
        [StringLength(10)]
        public string CatalogNumber { get; set; }

        [Required]
        [StringLength(82)]
        public string Name { get; set; }

        public int Hours { get; set; }

        public double Credits { get; set; }
    }
}
