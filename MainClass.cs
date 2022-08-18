using Newtonsoft.Json;

namespace DotaProject // Note: actual namespace depends on the project name.
{
    public class MainClass
    {
        public static object matchChat { get; private set; }

        public static void Main(string[] args)
        {
            var umbyId = 158315743;

            var istanceOfMyClass = new MainClass();
            var lastTenMatch = InitializateLastTenMatchsValues(umbyId.ToString()).Result;
            var listOfHeroe = InitializareHeroe().Result;
            List<MatchDTO> lastTenWithValue = new List<MatchDTO>();

            foreach (var match in lastTenMatch)
            {
                lastTenWithValue.Add(InitializateMatchsValues(match.MatchId.ToString()).Result);
            }  
            foreach (var matchWithValue in lastTenWithValue)
            {
                var heroeInMatch = matchWithValue.Players.Where(x => x.AccountId == umbyId).FirstOrDefault();
                var heroeName = listOfHeroe.Where(x => x.Id == heroeInMatch.HeroId).FirstOrDefault().Name;
                Console.WriteLine($"You Played with this heroe {heroeName}");
            } 
        }

        public async static Task<MatchDTO> InitializateMatchsValues(string matchId)
        {
            var dataRecived = await CommonService.getMatchDatas(matchId);
            var response = JsonConvert.DeserializeObject<MatchDTO>(dataRecived);
            return response;
        }
         public async static Task<List<MatchDTO>> InitializateLastTenMatchsValues(string playerId)
        {
            var dataRecived = await CommonService.getLastTenMatchDatas(playerId);
            var response = JsonConvert.DeserializeObject<List<MatchDTO>>(dataRecived);
            return response;
        }
        public async static Task<List<HeroeDTO>> InitializareHeroe()
        {
            var dataRecived = await CommonService.getListOfHeroes();
            var response = JsonConvert.DeserializeObject<List<HeroeDTO>>(dataRecived);
            return response;
        }           
    }
}



//76561198118581471
//https://api.opendota.com/api/players/{account_id}/matches