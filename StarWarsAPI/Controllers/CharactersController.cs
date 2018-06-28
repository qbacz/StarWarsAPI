using Newtonsoft.Json;
using Ninject;
using StarWarsAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Web.Http;

namespace StarWarsAPI.Controllers
{
    public class CharactersController : ApiController
    {
        public HttpResponseMessage Get(string nameContains)
        {
            var url = "https://swapi.co/api/people?search=" + nameContains;
            var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Accept = "application/json";
            var httpResponseMessage = this.Request.CreateResponse(HttpStatusCode.OK);
            var kernel = new StandardKernel();
                kernel.Load(Assembly.GetExecutingAssembly());
            var outputNamesList = new List<CharacterNameOutput>();
            string responseData;
            var converter = kernel.Get<IJsonToObjectDeserializer<Character>>();
            var convertedData = new ResponseData<Character>();

            try
            {
                do
                {
                    convertedData = converter.Deserialize(CallExternalAPI(url));

                    foreach (var character in convertedData.Results)
                    {
                        outputNamesList.Add(new CharacterNameOutput
                        {
                            Name = character.Name
                        });
                    }

                    url = convertedData.Next;
                } while (!String.IsNullOrEmpty(convertedData.Next));

                httpResponseMessage.Content = new StringContent(JsonConvert.SerializeObject(outputNamesList, Formatting.Indented), Encoding.UTF8, "application/json");

                return httpResponseMessage;
            }
            catch (Exception e)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent(e.Message) };
            }
        }

        private string CallExternalAPI(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);

            using (Stream webStream = request.GetResponse().GetResponseStream())
            {
                using (StreamReader responseReader = new StreamReader(webStream))
                {
                    return responseReader.ReadToEnd();
                }
            }
        }
    }
}
