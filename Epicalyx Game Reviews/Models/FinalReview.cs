using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Epicalyx_Game_Reviews.Models
{
    public class FinalReview
    {

        public int FinalReviewID { get; set; }
        public string Review { get; set; }
        [Display(Name = "Final Rating")]

        public int FinalRating { get; set; }

        public int GameID { get; set; }
        public int UserID { get; set; }


        public Game Game { get; set; }
        public User User { get; set; }
    }
}