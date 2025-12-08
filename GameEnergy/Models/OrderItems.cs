namespace GameEnergy.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class OrderItems
    {
        [Key]
        public int OrderItemID { get; set; }

        public int OrderID { get; set; }

        public int GameID { get; set; }

        public int PriceAtPurchase { get; set; }

        [StringLength(200)]
        public string GameKey { get; set; }

        public virtual Games Games { get; set; }

        public virtual Orders Orders { get; set; }
    }
}
