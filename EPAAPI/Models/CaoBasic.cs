//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CaoBasic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CaoBasic()
        {
            this.CaoBasicTypes = new HashSet<CaoBasicType>();
            this.PersonCaoLicenses = new HashSet<PersonCaoLicense>();
        }
    
        public int Id { get; set; }
        public Nullable<int> CaoBasicLicenseTypeId { get; set; }
        public string Title { get; set; }
        public string CaoGroup { get; set; }
        public string Remark { get; set; }
    
        public virtual CaoBasicLicenseType CaoBasicLicenseType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CaoBasicType> CaoBasicTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonCaoLicense> PersonCaoLicenses { get; set; }
    }
}
