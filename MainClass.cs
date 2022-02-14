// See https://aka.ms/new-console-template for more information
//2136628
//Server=localhost;Database=DotaProject;Trusted_Connection=True;
using System;
using Newtonsoft.Json;

namespace DotaProject // Note: actual namespace depends on the project name.
{
    public class MainClass
    {
        HttpService _ApiCall = new HttpService();

        public static object matchChat { get; private set; }

        public static void Main(string[] args)
        {
            var istanceOfMyClass = new MainClass();
            Console.WriteLine("Bella");
            var matchStats = JsonConvert.DeserializeObject<MatchDTO>(istanceOfMyClass.getDatas("2136628").Result);
            matchChat = matchStats?.Chat;

        }

        public async Task<string> getDatas(string MatchId)
        {
            return await _ApiCall.GetData(MatchId).Result.Content.ReadAsStringAsync();
        }

    }
}