namespace GameEnergy.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserLibrary")]
    public partial class UserLibrary
    {
        [Key]
        public int UserGameID { get; set; }

        public int? UserID { get; set; }

        public int? GameID { get; set; }

        public DateTime? AddedDate { get; set; }

        public virtual Games Games { get; set; }

        public virtual Users Users { get; set; }
    }
}
