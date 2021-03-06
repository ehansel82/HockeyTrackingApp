﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HockeyTrackingApp.Models.DAL
{
    public class HockeyAppDbInitializer : DropCreateDatabaseIfModelChanges<HockeyAppContext>
    {
        protected override void Seed (HockeyAppContext ctx)
        {
            ctx.Seasons.Add(new Season() { Year = 2016, SeasonName = "Spring", StartDate = new DateTime(2016, 1, 1), EndDate = new DateTime(2016, 3, 31) });
            ctx.Teams.Add(new Team() { Name = "Pittsburgh Penguins", Season = ctx.Seasons.First()});
            ctx.SaveChanges();
            ctx.Players.Add(new Player() { FirstName = "Mario", LastName = "Lemieux", Number = "66" , Team = ctx.Teams.First()});
            ctx.SaveChanges();
        }
    }
}