using SpecFlow_demo.acceptance_tests_api.utils;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using SpecFlow_demo.acceptance_tests_api.ResponseModel;
using Shouldly;

namespace SpecFlow_demo.acceptance_tests_api.steps
{

    [Binding]
    public class PhotoEndpointTestsSteps
    {

        public PhotoEndpointTestsSteps(SampleContext context)
        {
            this.context = context;
        }

        const string photoPath = "/photos";
        private readonly SampleContext context;
        private string targetUrl;


        [Given(@"I am requesting photo metadata")]
        public void GivenIAmRequestingPhotoMetadata()
        {
            targetUrl = context.Url + photoPath;
        }

        
        [Then(@"the response should include (.*) photos")]
        public void ThenTheResponseShouldIncludePhotos(int count)
        {
            context.PhotoList.ShouldNotBeEmpty();

            context.PhotoList.Count.ShouldBe(count);
        }
        
        [Then(@"each photo should include the field ""(.*)""")]
        public void ThenEachPhotoShouldIncludeTheField(string property)
        {
            context.PhotoList.ShouldNotBeEmpty();
            switch(property)
            {
               
            } 
        }
    }
}
