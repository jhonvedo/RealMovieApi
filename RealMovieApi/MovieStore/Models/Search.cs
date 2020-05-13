using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Models
{
  

  
  
    public class Search
    {

        [JsonProperty("score")]
        public Nullable<double> Score { get; set; }

        [JsonProperty("show")]
        public Show Show { get; set; }
    }
}
