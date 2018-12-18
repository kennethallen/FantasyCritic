using System;
using System.Collections.Generic;
using System.Linq;
using FantasyCritic.Lib.Domain;
using FantasyCritic.Lib.Domain.ScoringSystems;
using NodaTime;

namespace FantasyCritic.Web.Models.Responses
{
    public class StandingViewModel
    {
        public StandingViewModel(Publisher publisher, ScoringSystem scoringSystem, SystemWideValues systemWideValues)
        {
            PublisherID = publisher.PublisherID;
            LeagueID = publisher.League.LeagueID;
            PublisherName = publisher.PublisherName;
            LeagueName = publisher.League.LeagueName;
            PlayerName = publisher.User.DisplayName;
            Year = publisher.Year;
            TotalFantasyPoints = publisher.TotalFantasyPoints;
            ProjectedFantasyPoints = publisher.GetProjectedFantasyPoints(scoringSystem, systemWideValues);
        }

        public Guid PublisherID { get; }
        public Guid LeagueID { get; }
        public string PublisherName { get; }
        public string LeagueName { get; }
        public string PlayerName { get; }
        public int Year { get; }
        public decimal TotalFantasyPoints { get; }
        public decimal ProjectedFantasyPoints { get; }
    }
}
