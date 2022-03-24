namespace Epicalyx_Game_Reviews.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public int ProfilePic { get; set; }

        public List<FinalReview> FinalReview { get; set; }
    }
}