namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysssispackagefolder
    {
        [Key]
        public Guid folderid { get; set; }

        public Guid? parentfolderid { get; set; }

        [Required]
        [StringLength(128)]
        public string foldername { get; set; }
    }
}
