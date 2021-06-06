namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysdtscategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysdtscategory()
        {
            sysdtspackages = new HashSet<sysdtspackage>();
        }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        [StringLength(1024)]
        public string description { get; set; }

        public Guid id { get; set; }

        public Guid parentid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysdtspackage> sysdtspackages { get; set; }
    }
}
