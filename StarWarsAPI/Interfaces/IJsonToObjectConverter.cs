using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsAPI.Interfaces
{
    public interface IJsonToObjectDeserializer<T> where T : class
    {
        ResponseData<T> Deserialize(string json);
    }
}
