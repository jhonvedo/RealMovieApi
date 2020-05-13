using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
    public class ShowService
    {
        public const string PATH = "/shows";
     
        public List<Show> GetShows()
        {
            return Execute<List<Show>>(PATH);
        }
        public Show GetShow(int id)
        {
            string pathComplement = $"{PATH}/{id}";
            return Execute<Show>(pathComplement);
        }
        public List<Search> SearchShows(string query)
        {
            string pathComplement = $"{PATH}?q={query}";
            return Execute<List<Search>>(pathComplement);
        }

        public List<Season> GetSeasons(int showId)
        {
            string pathComplement = $"{PATH}/{showId}/seasons";
            return Execute<List<Season>>(pathComplement);
        }

        public Episode GetEpisode(int showId,int season,int episodeId)
        {
            string pathComplement = $"{PATH}/{showId}/episodebynumber?season={season}&number={episodeId}";
            return Execute<Episode>(pathComplement);
        }
        public List<Episode> GetEpisodes(int showId)
        {
            string pathComplement = $"{PATH}/{showId}/episodes";
            return Execute<List<Episode>>(pathComplement);
        }

        public List<Episode> GetEpisodesByDate(int showId,DateTime time)
        {
            string pathComplement = $"{PATH}/{showId}/episodesbydate?date={time.ToString("yyyy-MM-dd")}";
            return Execute<List<Episode>>(pathComplement);
        }


        public List<Cast> GetCast(int showId)
        {
            string pathComplement = $"{PATH}/{showId}/cast";
            return Execute<List<Cast>>(pathComplement);
        }

        public List<Crew> GetCrew(int showId)
        {
            string pathComplement = $"{PATH}/{showId}/crew";
            return Execute<List<Crew>>(pathComplement);
        }
        public List<Aka> GetAkas(int showId)
        {
            string pathComplement = $"{PATH}/{showId}/akas";
            return Execute<List<Aka>>(pathComplement);
        }

        public T Execute<T>(string path) where T : class
        {
            return HttpRequestBaseSingleton.GetInstance().ConsumeService<T>(path);
        }

    }
}
