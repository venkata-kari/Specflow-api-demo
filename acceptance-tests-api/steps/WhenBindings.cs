using SpecFlow_demo.acceptance_tests_api.utils;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using SpecFlow_demo.acceptance_tests_api.ResponseModel;

namespace SpecFlow_demo.acceptance_tests_api.steps
{
    [Binding]
    public class WhenBindings
    {

        public WhenBindings(SampleContext context)
        {
            this.context = context;
        }

        private readonly SampleContext context;


        [When(@"I make a request")]
        public void WhenIMakeARequest()
        {
            var response = HttpClient.Get(context.TargetUrl);
            var code = response.StatusCode;
            code.Equals(200);
            context.PhotoList = response.StaticBody<IList<PhotoResponse>>();
        }
    }
}
