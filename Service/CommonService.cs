namespace DotaProject
{
    public static class CommonService {
        
        
        public static async Task<string> getMatchDatas(string MatchId)
        {
            HttpService _ApiCall = HttpService.GetHttpService();
             var response = await _ApiCall.GetMatchData(MatchId).Result.Content.ReadAsStringAsync();
            return response;
        }
        public static async Task<string> getLastTenMatchDatas(string AccountId)
        {
            HttpService _ApiCall = HttpService.GetHttpService();
            var response = await _ApiCall.GetLastTenMatch(AccountId).Result.Content.ReadAsStringAsync();
            return response;
        }

        public static async Task<string> getListOfHeroes()
        {
            HttpService _ApiCall = HttpService.GetHttpService();
            var response = await _ApiCall.GetHeroeList().Result.Content.ReadAsStringAsync();
            return response;
        }


    }
    
}