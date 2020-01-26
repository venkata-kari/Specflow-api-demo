using EasyHttp.Http;

namespace SpecFlow_demo.acceptance_tests_api.utils
{
    class HttpClient
    {
      public static HttpResponse Get(string url)
        {
            var httpClient = new EasyHttp.Http.HttpClient();
            httpClient.Request.Accept = HttpContentTypes.ApplicationJson;

            return httpClient.Get(url);
        }
    }
}
