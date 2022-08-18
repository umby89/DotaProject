namespace DotaProject
{
    public class HttpService : IHttpService
    {
   
        private static readonly HttpService _httpService = new HttpService();
        public HttpClient client;

        public static HttpService GetHttpService()
        {
            _httpService.client = new HttpClient();
            return _httpService;
        }

        public async Task<HttpResponseMessage> GetMatchData(string MatchId)
        {
            _httpService.client.BaseAddress = new Uri($"https://api.opendota.com/api/matches/{(MatchId)}");

            try
            {
                return await _httpService.client.GetAsync(_httpService.client.BaseAddress);
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

        public async Task<HttpResponseMessage> GetLastTenMatch(string AccountId)
        {
            
            _httpService.client.BaseAddress = new Uri($"https://api.opendota.com/api/players/{AccountId}/matches?limit=10");

            try
            {
                return await _httpService.client.GetAsync(_httpService.client.BaseAddress);
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
        
        public async Task<HttpResponseMessage> GetHeroeList()
        {
            
            _httpService.client.BaseAddress = new Uri($"https://api.opendota.com/api/heroes");

            try
            {
                return await _httpService.client.GetAsync(_httpService.client.BaseAddress);
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
