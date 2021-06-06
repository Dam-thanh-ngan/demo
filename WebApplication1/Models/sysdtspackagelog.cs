namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sysdtspackagelog")]
    public partial class sysdtspackagelog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysdtspackagelog()
        {
            sysdtssteplogs = new HashSet<sysdtssteplog>();
        }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        [StringLength(1000)]
        public string description { get; set; }

        public Guid id { get; set; }

        public Guid versionid { get; set; }

        [Key]
        public Guid lineagefull { get; set; }

        public int lineageshort { get; set; }

        public DateTime starttime { get; set; }

        public DateTime? endtime { get; set; }

        public double? elapsedtime { get; set; }

        [Required]
        [StringLength(128)]
        public string computer { get; set; }

        [Column("operator")]
        [Required]
        [StringLength(128)]
        public string _operator { get; set; }

        public DateTime logdate { get; set; }

        public int? errorcode { get; set; }

        [StringLength(2000)]
        public string errordescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysdtssteplog> sysdtssteplogs { get; set; }
    }
}
