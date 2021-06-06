namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sysdtssteplog")]
    public partial class sysdtssteplog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysdtssteplog()
        {
            sysdtstasklogs = new HashSet<sysdtstasklog>();
        }

        [Key]
        public long stepexecutionid { get; set; }

        public Guid lineagefull { get; set; }

        [Required]
        [StringLength(128)]
        public string stepname { get; set; }

        public int? stepexecstatus { get; set; }

        public int? stepexecresult { get; set; }

        public DateTime starttime { get; set; }

        public DateTime? endtime { get; set; }

        public double? elapsedtime { get; set; }

        public int? errorcode { get; set; }

        [StringLength(2000)]
        public string errordescription { get; set; }

        public long? progresscount { get; set; }

        public virtual sysdtspackagelog sysdtspackagelog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysdtstasklog> sysdtstasklogs { get; set; }
    }
}
