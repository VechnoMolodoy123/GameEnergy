namespace GameEnergy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reviews
    {
        [Key]
        public int ReviewID { get; set; }

        public int? UserID { get; set; }

        public int? GameID { get; set; }

        public string Comment { get; set; }

        public int? LikesCount { get; set; }

        public DateTime? ReviewDate { get; set; }

        public virtual Games Games { get; set; }

        public virtual Users Users { get; set; }
    }
}
