using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Models
{
    public class Schedule
    {

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("days")]
        public IList<string> Days { get; set; }
    }

    public class Rating
    {

        [JsonProperty("average")]
        public Nullable<double> Average { get; set; }
    }   

    public class Externals
    {

        [JsonProperty("tvrage")]
        public Nullable<int> Tvrage { get; set; }

        [JsonProperty("thetvdb")]
        public Nullable<int> Thetvdb { get; set; }

        [JsonProperty("imdb")]
        public string Imdb { get; set; }
    }  

    public class Previousepisode
    {

        [JsonProperty("href")]
        public string Href { get; set; }
    }   

    public class Show
    {

        [JsonProperty("id")]
        public Nullable<int> Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("genres")]
        public IList<string> Genres { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("runtime")]
        public Nullable<int> Runtime { get; set; }

        [JsonProperty("premiered")]
        public string Premiered { get; set; }

        [JsonProperty("officialSite")]
        public string OfficialSite { get; set; }

        [JsonProperty("schedule")]
        public Schedule Schedule { get; set; }

        [JsonProperty("rating")]
        public Rating Rating { get; set; }

        [JsonProperty("weight")]
        public Nullable<int> Weight { get; set; }

        [JsonProperty("network")]
        public Network Network { get; set; }

        [JsonProperty("webChannel")]
        public object WebChannel { get; set; }

        [JsonProperty("externals")]
        public Externals Externals { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("updated")]
        public Nullable<int> Updated { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }
    }
}
