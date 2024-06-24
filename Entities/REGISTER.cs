//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Register
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Register()
        {
            this.CourseReviews = new HashSet<CourseReview>();
            this.TestResults = new HashSet<TestResult>();
        }
    
        public int register_id { get; set; }
        public int learner_id { get; set; }
        public int course_id { get; set; }
        public System.DateTime registered_date { get; set; }
        public int register_status { get; set; }
        public Nullable<double> completion_score { get; set; }
        public string course_certificate { get; set; }
        public decimal paid { get; set; }
        public Nullable<System.DateTime> time_finish { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Course Course { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseReview> CourseReviews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestResult> TestResults { get; set; }
    }
}
