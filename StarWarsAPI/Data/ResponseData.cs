using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWarsAPI
{
    public class ResponseData<T>
    {
        [JsonProperty("count")]
        public int Count
        {
            get;
            set;
        }

        [JsonProperty("results")]
        public List<T> Results
        {
            get;
            set;
        }

        [JsonProperty("next")]
        public string Next
        {
            get;
            set;
        }
    }
}