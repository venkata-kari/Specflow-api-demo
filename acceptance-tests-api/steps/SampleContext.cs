using System.Collections.Generic;
using SpecFlow_demo.acceptance_tests_api.ResponseModel;

namespace SpecFlow_demo.acceptance_tests_api.steps
{
    public class SampleContext
    {
        public string  Url  => "http://jsonplaceholder.typicode.com";

        public string TargetUrl => Url + "/photos";

        public IList<PhotoResponse> PhotoList = new List<PhotoResponse>();

    }
}
