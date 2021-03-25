using System.Net;

namespace dynamic_currency_converter
{
    class APIRequester
    {

        private string url;
        private WebClient client;

        public APIRequester(string url)
        {
            this.url = url;
            client = new WebClient();
        }

        public string SendAndGetResponse()
        {
            return client.DownloadString(url);
        }
    }
}