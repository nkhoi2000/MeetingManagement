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
    
    public partial class MEETING
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEETING()
        {
            this.ATTACHMENTs = new HashSet<ATTACHMENT>();
            this.MEMBERs = new HashSet<MEMBER>();
            this.TASKs = new HashSet<TASK>();
        }
    
        public int Category_id { get; set; }
        public int Meeting_id { get; set; }
        public string Meeting_name { get; set; }
        public string Meeting_content { get; set; }
        public System.DateTime Date_Start { get; set; }
        public Nullable<System.TimeSpan> Time_Start { get; set; }
        public string Location { get; set; }
        public int Status { get; set; }
        public Nullable<bool> Check_report { get; set; }
        public Nullable<System.DateTime> Date_Create { get; set; }
        public string Create_by { get; set; }
        public string Feedback { get; set; }
        public string AspNetUsers { get; set; }
        public Nullable<bool> Check_Task { get; set; }
        public string Verify_by { get; set; }
        public Nullable<bool> Notify { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTACHMENT> ATTACHMENTs { get; set; }
        public virtual CATEGORY CATEGORY { get; set; }
        public virtual MEETING_STATUS MEETING_STATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEMBER> MEMBERs { get; set; }
        public virtual REPORT REPORT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TASK> TASKs { get; set; }
    }
}
