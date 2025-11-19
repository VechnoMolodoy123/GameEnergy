namespace GameEnergy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SystemNotifications
    {
        [Key]
        public int NotifyID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string NotifyTitle { get; set; }

        [Required]
        public string NotifyMessage { get; set; }

        public DateTime NotifyDate { get; set; }

        public virtual Users Users { get; set; }
    }
}
