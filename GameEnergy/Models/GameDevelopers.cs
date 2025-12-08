namespace GameEnergy.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class GameDevelopers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GameDevelopers()
        {
            Games = new HashSet<Games>();
        }

        [Key]
        public int DeveloperID { get; set; }

        [Required]
        [StringLength(100)]
        public string DeveloperName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Games> Games { get; set; }
    }
}
