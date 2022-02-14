namespace DotaProject
{
    interface IHttpService
    {
        
        Task<HttpResponseMessage> GetData(string MatchId);
        HttpResponseMessage GetMessage();
        HttpResponseMessage IsAlive();
    }
}