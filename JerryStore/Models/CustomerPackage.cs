//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JerryStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerPackage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerPackage()
        {
            this.CustomerPackageTasks = new HashSet<CustomerPackageTask>();
        }
    
        public int CustomerID { get; set; }
        public int PackageID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Package Package { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerPackageTask> CustomerPackageTasks { get; set; }
    }
}
