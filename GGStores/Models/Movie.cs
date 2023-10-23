using GGStores.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GGStores.Models
{
    public class Movie
    {
        [Display(Name = "Movie Name")]
        public string Name { get; set; }
        [Key]
        public int Id { get; set; }

        [Display(Name = "Movie Discription")]
        public string Description { get; set; }
        public double Price { get; set; }

        [Display(Name = "Movie Image")]
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }


        public List<Actor_Movie> Actor_Movies { get; set; }

        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }



        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }



    }
}
