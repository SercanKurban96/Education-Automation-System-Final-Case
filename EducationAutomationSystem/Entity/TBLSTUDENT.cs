//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EducationAutomationSystem.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLSTUDENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLSTUDENT()
        {
            this.TBLNOTE = new HashSet<TBLNOTE>();
        }
    
        public int StudentID { get; set; }
        public Nullable<long> StudentTRNumber { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentNumber { get; set; }
        public Nullable<System.DateTime> StudentBirthDate { get; set; }
        public string StudentBirthPlace { get; set; }
        public string StudentGender { get; set; }
        public string MothersName { get; set; }
        public string FathersName { get; set; }
        public Nullable<int> Department { get; set; }
        public Nullable<int> City { get; set; }
        public Nullable<int> District { get; set; }
        public string Neighborhood { get; set; }
        public Nullable<int> PostalCode { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string StudentMail { get; set; }
        public string StudentPicture { get; set; }
    
        public virtual iller iller { get; set; }
        public virtual TBLDEPARTMENT TBLDEPARTMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLNOTE> TBLNOTE { get; set; }
    }
}
