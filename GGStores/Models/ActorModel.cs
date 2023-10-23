using System.ComponentModel.DataAnnotations;

namespace GGStores.Models
{
    public class ActorModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePicture { get; set; }

        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars ")]
        public string FullName { get; set; }

        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Bio is required")]
        public string Bio { get; set; }


        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}
