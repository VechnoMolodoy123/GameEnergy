namespace GameEnergy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Games
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Games()
        {
            CartItems = new HashSet<CartItems>();
            GameReports = new HashSet<GameReports>();
            OrderItems = new HashSet<OrderItems>();
            Rating = new HashSet<Rating>();
            Reviews = new HashSet<Reviews>();
            UserLibrary = new HashSet<UserLibrary>();
            Genres = new HashSet<Genres>();
        }

        [Key]
        public int GameID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public int? DeveloperID { get; set; }

        public string Description { get; set; }

        [StringLength(255)]
        public string GameImage { get; set; }

        [StringLength(255)]
        public string TrailerImage { get; set; }

        public int? CategoryID { get; set; }

        public decimal? AverageRating { get; set; }

        public DateTime? AddedDate { get; set; }

        public int? Price { get; set; }

        public int? DiscountedPrice { get; set; }

        public int? Discount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReleaseDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CartItems> CartItems { get; set; }

        public virtual GameDevelopers GameDevelopers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GameReports> GameReports { get; set; }

        public virtual MainCategory MainCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItems> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rating> Rating { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reviews> Reviews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserLibrary> UserLibrary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Genres> Genres { get; set; }
    }
}
