using Ninject.Modules;
using StarWarsAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWarsAPI
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IJsonToObjectDeserializer<Character>>().To<JsonToObjectDeserializer<Character>>();
        }
    }
}