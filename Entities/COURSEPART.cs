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
    
    public partial class COURSEPART
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COURSEPART()
        {
            this.COURSERESOURCEs = new HashSet<COURSERESOURCE>();
            this.COURSETESTs = new HashSet<COURSETEST>();
        }
    
        public int part_id { get; set; }
        public int course_id { get; set; }
        public string part_name { get; set; }
    
        public virtual COURSE COURSE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COURSERESOURCE> COURSERESOURCEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COURSETEST> COURSETESTs { get; set; }
    }
}
