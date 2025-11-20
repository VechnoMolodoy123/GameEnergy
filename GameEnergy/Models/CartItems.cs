namespace GameEnergy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CartItems
    {
        [Key]
        public int CartItemID { get; set; }

        public int CartID { get; set; }

        public int GameID { get; set; }

        public decimal PriceAtAdd { get; set; }

        public DateTime AddedDate { get; set; }

        public virtual Cart Cart { get; set; }

        public virtual Games Games { get; set; }
    }
}
