namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class log_shipping_secondaries
    {
        public int? primary_id { get; set; }

        [Key]
        [Column(Order = 0)]
        public string secondary_server_name { get; set; }

        [Key]
        [Column(Order = 1)]
        public string secondary_database_name { get; set; }

        [StringLength(500)]
        public string last_copied_filename { get; set; }

        [StringLength(500)]
        public string last_loaded_filename { get; set; }

        public DateTime? last_copied_last_updated { get; set; }

        public DateTime? last_loaded_last_updated { get; set; }

        public Guid? secondary_plan_id { get; set; }

        public bool? copy_enabled { get; set; }

        public bool? load_enabled { get; set; }

        public int? out_of_sync_threshold { get; set; }

        public int? threshold_alert { get; set; }

        public bool? threshold_alert_enabled { get; set; }

        public int? planned_outage_start_time { get; set; }

        public int? planned_outage_end_time { get; set; }

        public int? planned_outage_weekday_mask { get; set; }

        public bool? allow_role_change { get; set; }

        public virtual log_shipping_primaries log_shipping_primaries { get; set; }
    }
}
