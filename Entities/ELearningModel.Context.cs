﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elearning.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ELearningDbEntities : DbContext
    {
        public ELearningDbEntities()
            : base("name=ELearningDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseModule> CourseModules { get; set; }
        public virtual DbSet<CourseResource> CourseResources { get; set; }
        public virtual DbSet<CourseReview> CourseReviews { get; set; }
        public virtual DbSet<CourseTest> CourseTests { get; set; }
        public virtual DbSet<Register> Registers { get; set; }
        public virtual DbSet<TestQuestion> TestQuestions { get; set; }
        public virtual DbSet<TestResult> TestResults { get; set; }
    }
}
