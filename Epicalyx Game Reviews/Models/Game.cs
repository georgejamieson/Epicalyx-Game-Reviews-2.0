using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Epicalyx_Game_Reviews.Models
{
    public class Game
    {
        public int GameID { get; set; }
        [Required]
        [Display(Name = "Game Name")]
        public string GameName { get; set; }
        [Display(Name = "Age Rating")]
        [Required]
        [StringLength(3)]
        public string AgeRating { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Display(Name = "Release Year")]
        [Required]
        public int ReleaseYear { get; set; }

        public List<FinalReview> FinalReview { get; set; }
        public List<AspectReview> AspectReview { get; set; }

    }
}
