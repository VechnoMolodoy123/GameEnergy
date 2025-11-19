namespace GameEnergy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderItems
    {
        [Key]
        public int OrderItemID { get; set; }

        public int OrderID { get; set; }

        public int GameID { get; set; }

        public decimal PriceAtPurchase { get; set; }

        public virtual Games Games { get; set; }

        public virtual Orders Orders { get; set; }
    }
}
