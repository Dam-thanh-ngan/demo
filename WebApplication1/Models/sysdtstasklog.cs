namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sysdtstasklog")]
    public partial class sysdtstasklog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long stepexecutionid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sequenceid { get; set; }

        public int errorcode { get; set; }

        [StringLength(2000)]
        public string description { get; set; }

        public virtual sysdtssteplog sysdtssteplog { get; set; }
    }
}
