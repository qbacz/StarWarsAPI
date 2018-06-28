using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarWarsAPI;
using StarWarsAPI.Controllers;

namespace StarWarsAPI.Tests.Controllers
{
    [TestClass]
    public class CharactersControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            var controller = new CharactersController();
            controller.Request = new HttpRequestMessage();  

            // Act
            var result = controller.Get("");

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
