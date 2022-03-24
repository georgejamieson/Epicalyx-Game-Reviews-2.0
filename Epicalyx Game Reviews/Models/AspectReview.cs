using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Epicalyx_Game_Reviews.Models
{
    public class AspectReview
    {
        public int AspectReviewID { get; set; }
        [Display(Name = "Story Rating")]
        public int StoryRating { get; set; }
        [Display(Name = "Soundtrack Rating")]
        public int SoundtrackRating { get; set; }
        [Display(Name = "Graphics Rating")]
        public int GraphicsRating { get; set; }
        [Display(Name = "Gameplay Rating")]
        public int GameplayRating { get; set; }
        [Display(Name = "Multiplayer Rating")]
        public int? MultiplayerRating { get; set; }
        [Display(Name = "Story Completion %")]
        public decimal? StoryCompletion { get; set; }
        [Display(Name = "Total Completion")]
        public decimal? TotalCompletion { get; set; }
        public int UserID { get; set; }
        public int GameID { get; set; }


        public User User { get; set; }
        public Game Game { get; set; }


    }
}