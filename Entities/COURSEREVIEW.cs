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
    
    public partial class CourseReview
    {
        public int review_id { get; set; }
        public int register_id { get; set; }
        public System.DateTime review_time { get; set; }
        public string content { get; set; }
        public Nullable<int> stars { get; set; }
    
        public virtual Register Register { get; set; }
    }
}
