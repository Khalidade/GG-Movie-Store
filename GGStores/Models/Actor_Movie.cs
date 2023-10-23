namespace GGStores.Models
{
    public class Actor_Movie
    {
        public int Movieid { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }

        public ActorModel Actor { get; set; }

    }
}
