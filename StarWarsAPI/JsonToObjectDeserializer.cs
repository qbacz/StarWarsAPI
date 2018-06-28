using StarWarsAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Newtonsoft.Json;
namespace StarWarsAPI
{
    public class JsonToObjectDeserializer<T> : IJsonToObjectDeserializer<T> where T : class
    {
        public ResponseData<T> Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<ResponseData<T>>(json);
        }
    }
}