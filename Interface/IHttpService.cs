namespace DotaProject
{
    interface IHttpService
    {
        Task<HttpResponseMessage> GetMatchData(string MatchId);
        Task<HttpResponseMessage> GetLastTenMatch(string AccountId, int? numberoOfMatch);
        Task<HttpResponseMessage> GetHeroeList();
        HttpResponseMessage GetMessage();
        HttpResponseMessage IsAlive();
    }
}