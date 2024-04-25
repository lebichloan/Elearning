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
    
    public partial class COURSE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COURSE()
        {
            this.COURSEPARTs = new HashSet<COURSEPART>();
            this.REGISTERs = new HashSet<REGISTER>();
        }
    
        public int course_id { get; set; }
        public string course_name { get; set; }
        public string lecturer { get; set; }
        public string course_image { get; set; }
        public int created_by { get; set; }
        public int price { get; set; }
        public string course_description { get; set; }
        public Nullable<decimal> stars { get; set; }
    
        public virtual ACCOUNT ACCOUNT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COURSEPART> COURSEPARTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTER> REGISTERs { get; set; }
    }
}
