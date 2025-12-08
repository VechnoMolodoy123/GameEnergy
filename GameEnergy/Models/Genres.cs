namespace GameEnergy.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Genres
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Genres()
        {
            GameGenres = new HashSet<GameGenres>();
        }

        [Key]
        public int GenreID { get; set; }

        [Required]
        [StringLength(50)]
        public string GenreName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GameGenres> GameGenres { get; set; }
    }
}
