#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Epicalyx_Game_Reviews.Models;

    public class Epicalyx_Game_ReviewsContextDb : DbContext
    {
        public Epicalyx_Game_ReviewsContextDb (DbContextOptions<Epicalyx_Game_ReviewsContextDb> options)
            : base(options)
        {
        }

        public DbSet<Epicalyx_Game_Reviews.Models.Game> Game { get; set; }

        public DbSet<Epicalyx_Game_Reviews.Models.FinalReview> FinalReview { get; set; }

        public DbSet<Epicalyx_Game_Reviews.Models.AspectReview> AspectReview { get; set; }

        public DbSet<Epicalyx_Game_Reviews.Models.User> User { get; set; }
    }
