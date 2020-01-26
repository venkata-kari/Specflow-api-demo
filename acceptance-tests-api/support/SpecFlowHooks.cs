using System;
using System.Configuration;
using System.Net;
using SpecFlow_demo.acceptance_tests_api.utils;
using TechTalk.SpecFlow;

namespace SpecFlow_demo.acceptance_tests_api.support
{
    [Binding]
    class SpecFlowHooks
    {
        [BeforeScenario]
        public static void BeforeScenario()
        {
            HealthCheck();
        }

        private static void HealthCheck()
        {
            //var url = ConfigurationManager.AppSettings["ApiUri"];
            var url = "https://jsonplaceholder.typicode.com/todos/1";
            var healthCheckResponse = HttpClient.Get(url);
            if (healthCheckResponse.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(string.Format("Request to {0} did not return OK", url));
            }

            Console.WriteLine("Request to {0} returned OK", url);
        }

    }
}
