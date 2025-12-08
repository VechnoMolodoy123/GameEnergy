namespace GameEnergy.Models
{
    public partial class GameGenres
    {
        public int Id { get; set; }

        public int GameID { get; set; }

        public int GenreID { get; set; }

        public virtual Games Games { get; set; }

        public virtual Genres Genres { get; set; }
    }
}
