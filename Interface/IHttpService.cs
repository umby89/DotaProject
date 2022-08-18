namespace DotaProject
{
    interface IHttpService
    {
        Task<HttpResponseMessage> GetMatchData(string MatchId);
        Task<HttpResponseMessage> GetLastTenMatch(string AccountId);
        Task<HttpResponseMessage> GetHeroeList();
        HttpResponseMessage GetMessage();
        HttpResponseMessage IsAlive();
    }
}