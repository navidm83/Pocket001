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
    
    public partial class PersonEducation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonEducation()
        {
            this.PersonEducationDocuments = new HashSet<PersonEducationDocument>();
        }
    
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int EducationDegreeId { get; set; }
        public Nullable<System.DateTime> DateCatch { get; set; }
        public string College { get; set; }
        public string Remark { get; set; }
        public string Title { get; set; }
        public int StudyFieldId { get; set; }
        public string FileTitle { get; set; }
        public string FileType { get; set; }
        public string FileUrl { get; set; }
        public string SysUrl { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonEducationDocument> PersonEducationDocuments { get; set; }
        public virtual Person Person { get; set; }
    }
}
