namespace DotaProject
{
    public class HttpService : IHttpService
    {
   
        private static readonly HttpService _httpService = new HttpService();
        public HttpClient client;
        string apiUri = DotaPersonalProjectTEST.Properties.Resources.ApiUrl;
        int _numberOfMatchListed = Convert.ToInt32(DotaPersonalProjectTEST.Properties.Resources.numerOfMatchListed);

        public static HttpService GetHttpService()
        {
            _httpService.client = new HttpClient();
            return _httpService;
        }

        public async Task<HttpResponseMessage> GetMatchData(string MatchId)
        {
            _httpService.client.BaseAddress = new Uri($"{apiUri}matches/{(MatchId)}");

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

        public async Task<HttpResponseMessage> GetLastTenMatch(string AccountId,int? numberOfMatchListed)
        {
            if (numberOfMatchListed == null || numberOfMatchListed == 0)
            {
                numberOfMatchListed = this._numberOfMatchListed;
            }
            _httpService.client.BaseAddress = new Uri($"{apiUri}players/{AccountId}/matches?limit={numberOfMatchListed}");

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
            
            _httpService.client.BaseAddress = new Uri($"{apiUri}heroes");

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
