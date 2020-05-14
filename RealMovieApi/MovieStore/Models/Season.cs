using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Models
{
    public class Season
    {

        [JsonProperty("id")]
        public Nullable<int> Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("number")]
        public Nullable<int> Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("episodeOrder")]
        public Nullable<int> EpisodeOrder { get; set; }

        [JsonProperty("premiereDate")]
        public string PremiereDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("network")]
        public Network Network { get; set; }

        [JsonProperty("webChannel")]
        public WebChannel WebChannel { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }
    }
}
