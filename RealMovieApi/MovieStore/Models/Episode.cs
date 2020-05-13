using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Models
{

 
    public class Episode
    {

        [JsonProperty("id")]
        public Nullable<int> Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("season")]
        public Nullable<int> Season { get; set; }

        [JsonProperty("number")]
        public Nullable<int> Number { get; set; }

        [JsonProperty("airdate")]
        public string Airdate { get; set; }

        [JsonProperty("airtime")]
        public string Airtime { get; set; }

        [JsonProperty("airstamp")]
        public Nullable<DateTime> Airstamp { get; set; }

        [JsonProperty("runtime")]
        public Nullable<int> Runtime { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }
    }
}
