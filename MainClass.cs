using Newtonsoft.Json;

namespace DotaProject
{
    public class MainClass
    {
        public static object matchChat { get; private set; }

        public static void Main(string[] args)
        {
            var umbyId = Convert.ToInt32(DotaPersonalProjectTEST.Properties.Resources.umbyId);
            var victoryCount = 0;
            var defeatCount = 0;
            var istanceOfMyClass = new MainClass();
            var lastTenMatch = InitializateLastTenMatchsValues(umbyId.ToString()).Result;
            var listOfHeroe = InitializareHeroe().Result;
            List<MatchDTO> lastMatchesWithValue = new List<MatchDTO>();

            foreach (var match in lastTenMatch)
            {
                lastMatchesWithValue.Add(InitializateMatchsValues(match.MatchId.ToString()).Result);
            }

            var totalMatchs = lastMatchesWithValue.Count();

            foreach (var matchWithValue in lastMatchesWithValue)
            {
                
             
                var heroeInMatch = matchWithValue.Players.Where(x => x.AccountId == umbyId).FirstOrDefault();
                var heroeName = listOfHeroe.Where(x => x.Id == heroeInMatch.HeroId).FirstOrDefault().Name;
                var playerSide = heroeInMatch.IsRadiant;
                var playerVictory = string.Empty;

                if ((matchWithValue.RadiantWin && playerSide) || (!matchWithValue.RadiantWin && !playerSide))
                {
                    playerVictory = "Win";
                    victoryCount++;
                }
                else
                {
                    playerVictory = "Lose";
                    defeatCount++;
                }

                Console.WriteLine($"You Played with this heroe {heroeName}and the result of the match was: {playerVictory}");         

            }

             Console.WriteLine($"The winrate of the last matches is : {(Convert.ToDouble(victoryCount) / Convert.ToDouble(totalMatchs)) * 100}% ");
        }

        public async static Task<MatchDTO> InitializateMatchsValues(string matchId)
        {
            var dataRecived = await CommonService.getMatchDatas(matchId);
            var response = JsonConvert.DeserializeObject<MatchDTO>(dataRecived);
            return response;
        }
         public async static Task<List<MatchDTO>> InitializateLastTenMatchsValues(string playerId)
        {
            var dataRecived = await CommonService.getLastTenMatchDatas(playerId, null);
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