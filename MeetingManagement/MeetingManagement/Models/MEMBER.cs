//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeetingManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MEMBER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEMBER()
        {
            this.TASKs = new HashSet<TASK>();
        }
    
        public int Meeting_id { get; set; }
        public string Member_id { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual MEETING MEETING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TASK> TASKs { get; set; }
    }
}
