namespace GameEnergy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
