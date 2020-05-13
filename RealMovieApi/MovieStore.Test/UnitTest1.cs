using MovieStore.Services;
using System;
using Xunit;

namespace MovieStore.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ShowService show = new ShowService();
            var response1 = show.GetShows();
            var response2 = show.GetShow(1);
            var response3 = show.SearchShows("girl");
            var response4 = show.GetSeasons(1);
            var response5 = show.GetEpisodes(1);
            var response6 = show.GetEpisode(1, 1, 1);
            var response7 = show.GetEpisodesByDate(1, new DateTime(2013, 07, 01));
            var response8 = show.GetCast(1);
            var response9 = show.GetCrew(1);
            var response10 = show.GetAkas(1);

        }
    }
}
