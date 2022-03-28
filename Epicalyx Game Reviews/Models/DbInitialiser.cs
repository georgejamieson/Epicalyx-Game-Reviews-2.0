using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;





namespace Epicalyx_Game_Reviews.Models
{
    public class DbInitialiser
    {
        private readonly Epicalyx_Game_ReviewsContextDb epicalyx_Game_ReviewsContextDb;
        public DbInitialiser(Epicalyx_Game_ReviewsContextDb epicalyx_Game_ReviewsContextDb)
        {
            this.epicalyx_Game_ReviewsContextDb = epicalyx_Game_ReviewsContextDb;

        }




        public void Seed()
        {
            if (!epicalyx_Game_ReviewsContextDb.Game.Any())
            {

                new Game()
                {
                    GameName = "Red Dead Redemption 2",
                    AgeRating = "R16",
                    Genre = "Action",
                    Publisher = "Rockstar",
                    ReleaseYear = 2018
                };

                epicalyx_Game_ReviewsContextDb.SaveChanges();


            }
        }
    }
}
    







