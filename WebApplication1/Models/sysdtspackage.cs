namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysdtspackage
    {
        [Required]
        [StringLength(128)]
        public string name { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid versionid { get; set; }

        [StringLength(1024)]
        public string description { get; set; }

        public Guid categoryid { get; set; }

        public DateTime? createdate { get; set; }

        [Required]
        [StringLength(128)]
        public string owner { get; set; }

        [Column(TypeName = "image")]
        public byte[] packagedata { get; set; }

        [Required]
        [MaxLength(85)]
        public byte[] owner_sid { get; set; }

        public int packagetype { get; set; }

        public virtual sysdtscategory sysdtscategory { get; set; }
    }
}
