namespace DotaProject
{
    public class HttpService : IHttpService
    {

        HttpClient _client = new HttpClient();


        public async Task<HttpResponseMessage> GetData(string MatchId)
        {
            _client.BaseAddress = new Uri($"https://api.opendota.com/api/matches/{(MatchId)}");

            try
            {
                return await _client.GetAsync(_client.BaseAddress);
            }
            catch (System.Exception err)
            {
                return new  HttpResponseMessage()
                {
                    StatusCode = new System.Net.HttpStatusCode()
                    {

                    }
                };
            }
        }

        public HttpResponseMessage GetMessage()
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage IsAlive()
        {
            throw new NotImplementedException();
        }
    }
}
