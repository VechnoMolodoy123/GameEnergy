namespace GameEnergy.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

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
