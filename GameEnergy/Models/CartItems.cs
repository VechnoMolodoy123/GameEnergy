namespace GameEnergy.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class CartItems
    {
        [Key]
        public int CartItemID { get; set; }

        public int CartID { get; set; }

        public int GameID { get; set; }

        public int PriceAtAdd { get; set; }

        public DateTime AddedDate { get; set; }

        public virtual Cart Cart { get; set; }

        public virtual Games Games { get; set; }
    }
}
