using AllStarsSolution.DriverCore;
using ApiTestProject.Constants;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTestProject
{
    [TestFixture]
    public class SmokeApiTests
    {
        [Test]
        public void Test()
        {
            var restClient = new RestClient(Configuration.StartUrl);
            var request = new RestRequest(Endpoints.ListUsers, Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute(request);
            var b = response.Content;
        }

        [Test]
        public void Test2()
        {
        }

        [Test]
        public void Test3()
        {
        }
    }
}
