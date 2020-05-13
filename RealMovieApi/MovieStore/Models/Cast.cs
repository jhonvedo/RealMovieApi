using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Models
{


   
    public class Character
    {

        [JsonProperty("id")]
        public Nullable<int> Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }
    }

    public class Cast
    {

        [JsonProperty("person")]
        public Person Person { get; set; }

        [JsonProperty("character")]
        public Character Character { get; set; }

        [JsonProperty("self")]
        public bool Self { get; set; }

        [JsonProperty("voice")]
        public bool Voice { get; set; }
    }

}
