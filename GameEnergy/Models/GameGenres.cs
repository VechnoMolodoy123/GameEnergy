namespace GameEnergy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GameGenres
    {
        public int GameID { get; set; }

        public int GenreID { get; set; }

        public int Id { get; set; }

        public virtual Games Games { get; set; }

        public virtual Genres Genres { get; set; }
    }
}
