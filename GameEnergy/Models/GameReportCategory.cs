namespace GameEnergy.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("GameReportCategory")]
    public partial class GameReportCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GameReportCategory()
        {
            GameReports = new HashSet<GameReports>();
        }

        [Key]
        public int ReportCategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string ReportCategoryName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GameReports> GameReports { get; set; }
    }
}
