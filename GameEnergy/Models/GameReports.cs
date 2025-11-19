namespace GameEnergy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GameReports
    {
        [Key]
        public int GameReportID { get; set; }

        public int UserID { get; set; }

        public int GameID { get; set; }

        public int ReportCategoryID { get; set; }

        [Required]
        public string ReportMessage { get; set; }

        public DateTime ReportDate { get; set; }

        public virtual GameReportCategory GameReportCategory { get; set; }

        public virtual Games Games { get; set; }

        public virtual Users Users { get; set; }
    }
}
