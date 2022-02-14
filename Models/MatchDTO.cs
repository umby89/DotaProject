using Newtonsoft.Json;

namespace DotaProject
{
  // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class GoldPerMin
    {
        [JsonProperty("raw")]
        public int Raw;

        [JsonProperty("pct")]
        public double Pct;
    }

    public class XpPerMin
    {
        [JsonProperty("raw")]
        public int Raw;

        [JsonProperty("pct")]
        public double Pct;
    }

    public class KillsPerMin
    {
        [JsonProperty("raw")]
        public double Raw;

        [JsonProperty("pct")]
        public double Pct;
    }

    public class LastHitsPerMin
    {
        [JsonProperty("raw")]
        public double Raw;

        [JsonProperty("pct")]
        public double Pct;
    }

    public class HeroDamagePerMin
    {
        [JsonProperty("raw")]
        public int Raw;

        [JsonProperty("pct")]
        public double Pct;
    }

    public class HeroHealingPerMin
    {
        [JsonProperty("raw")]
        public int Raw;

        [JsonProperty("pct")]
        public double Pct;
    }

    public class TowerDamage
    {
    }

    public class StunsPerMin
    {
        [JsonProperty("raw")]
        public int Raw;

        [JsonProperty("pct")]
        public double Pct;
    }

    public class Lhten
    {
    }

    public class Benchmarks
    {
        [JsonProperty("gold_per_min")]
        public GoldPerMin GoldPerMin;

        [JsonProperty("xp_per_min")]
        public XpPerMin XpPerMin;

        [JsonProperty("kills_per_min")]
        public KillsPerMin KillsPerMin;

        [JsonProperty("last_hits_per_min")]
        public LastHitsPerMin LastHitsPerMin;

        [JsonProperty("hero_damage_per_min")]
        public HeroDamagePerMin HeroDamagePerMin;

        [JsonProperty("hero_healing_per_min")]
        public HeroHealingPerMin HeroHealingPerMin;

        [JsonProperty("tower_damage")]
        public TowerDamage TowerDamage;

        [JsonProperty("stuns_per_min")]
        public StunsPerMin StunsPerMin;

        [JsonProperty("lhten")]
        public Lhten Lhten;
    }

    public class Player
    {
        [JsonProperty("match_id")]
        public int MatchId;

        [JsonProperty("player_slot")]
        public int PlayerSlot;

        [JsonProperty("ability_targets")]
        public object AbilityTargets;

        [JsonProperty("ability_upgrades_arr")]
        public object AbilityUpgradesArr;

        [JsonProperty("ability_uses")]
        public object AbilityUses;

        [JsonProperty("account_id")]
        public int? AccountId;

        [JsonProperty("actions")]
        public object Actions;

        [JsonProperty("additional_units")]
        public object AdditionalUnits;

        [JsonProperty("assists")]
        public int Assists;

        [JsonProperty("backpack_0")]
        public object Backpack0;

        [JsonProperty("backpack_1")]
        public object Backpack1;

        [JsonProperty("backpack_2")]
        public object Backpack2;

        [JsonProperty("backpack_3")]
        public object Backpack3;

        [JsonProperty("buyback_log")]
        public object BuybackLog;

        [JsonProperty("camps_stacked")]
        public object CampsStacked;

        [JsonProperty("connection_log")]
        public object ConnectionLog;

        [JsonProperty("creeps_stacked")]
        public object CreepsStacked;

        [JsonProperty("damage")]
        public object Damage;

        [JsonProperty("damage_inflictor")]
        public object DamageInflictor;

        [JsonProperty("damage_inflictor_received")]
        public object DamageInflictorReceived;

        [JsonProperty("damage_taken")]
        public object DamageTaken;

        [JsonProperty("damage_targets")]
        public object DamageTargets;

        [JsonProperty("deaths")]
        public int Deaths;

        [JsonProperty("denies")]
        public int Denies;

        [JsonProperty("dn_t")]
        public object DnT;

        [JsonProperty("firstblood_claimed")]
        public object FirstbloodClaimed;

        [JsonProperty("gold")]
        public object Gold;

        [JsonProperty("gold_per_min")]
        public int GoldPerMin;

        [JsonProperty("gold_reasons")]
        public object GoldReasons;

        [JsonProperty("gold_spent")]
        public object GoldSpent;

        [JsonProperty("gold_t")]
        public object GoldT;

        [JsonProperty("hero_damage")]
        public object HeroDamage;

        [JsonProperty("hero_healing")]
        public object HeroHealing;

        [JsonProperty("hero_hits")]
        public object HeroHits;

        [JsonProperty("hero_id")]
        public int HeroId;

        [JsonProperty("item_0")]
        public int Item0;

        [JsonProperty("item_1")]
        public int Item1;

        [JsonProperty("item_2")]
        public int Item2;

        [JsonProperty("item_3")]
        public int Item3;

        [JsonProperty("item_4")]
        public int Item4;

        [JsonProperty("item_5")]
        public int Item5;

        [JsonProperty("item_neutral")]
        public object ItemNeutral;

        [JsonProperty("item_uses")]
        public object ItemUses;

        [JsonProperty("kill_streaks")]
        public object KillStreaks;

        [JsonProperty("killed")]
        public object Killed;

        [JsonProperty("killed_by")]
        public object KilledBy;

        [JsonProperty("kills")]
        public int Kills;

        [JsonProperty("kills_log")]
        public object KillsLog;

        [JsonProperty("lane_pos")]
        public object LanePos;

        [JsonProperty("last_hits")]
        public int LastHits;

        [JsonProperty("leaver_status")]
        public int LeaverStatus;

        [JsonProperty("level")]
        public int Level;

        [JsonProperty("lh_t")]
        public object LhT;

        [JsonProperty("life_state")]
        public object LifeState;

        [JsonProperty("max_hero_hit")]
        public object MaxHeroHit;

        [JsonProperty("multi_kills")]
        public object MultiKills;

        [JsonProperty("net_worth")]
        public object NetWorth;

        [JsonProperty("obs")]
        public object Obs;

        [JsonProperty("obs_left_log")]
        public object ObsLeftLog;

        [JsonProperty("obs_log")]
        public object ObsLog;

        [JsonProperty("obs_placed")]
        public object ObsPlaced;

        [JsonProperty("party_id")]
        public object PartyId;

        [JsonProperty("party_size")]
        public object PartySize;

        [JsonProperty("performance_others")]
        public object PerformanceOthers;

        [JsonProperty("permanent_buffs")]
        public object PermanentBuffs;

        [JsonProperty("pings")]
        public object Pings;

        [JsonProperty("pred_vict")]
        public object PredVict;

        [JsonProperty("purchase")]
        public object Purchase;

        [JsonProperty("purchase_log")]
        public object PurchaseLog;

        [JsonProperty("randomed")]
        public object Randomed;

        [JsonProperty("repicked")]
        public object Repicked;

        [JsonProperty("roshans_killed")]
        public object RoshansKilled;

        [JsonProperty("rune_pickups")]
        public object RunePickups;

        [JsonProperty("runes")]
        public object Runes;

        [JsonProperty("runes_log")]
        public object RunesLog;

        [JsonProperty("sen")]
        public object Sen;

        [JsonProperty("sen_left_log")]
        public object SenLeftLog;

        [JsonProperty("sen_log")]
        public object SenLog;

        [JsonProperty("sen_placed")]
        public object SenPlaced;

        [JsonProperty("stuns")]
        public object Stuns;

        [JsonProperty("teamfight_participation")]
        public object TeamfightParticipation;

        [JsonProperty("times")]
        public object Times;

        [JsonProperty("tower_damage")]
        public object TowerDamage;

        [JsonProperty("towers_killed")]
        public object TowersKilled;

        [JsonProperty("xp_per_min")]
        public int XpPerMin;

        [JsonProperty("xp_reasons")]
        public object XpReasons;

        [JsonProperty("xp_t")]
        public object XpT;

        [JsonProperty("personaname")]
        public string Personaname;

        [JsonProperty("name")]
        public object Name;

        [JsonProperty("last_login")]
        public object LastLogin;

        [JsonProperty("radiant_win")]
        public bool RadiantWin;

        [JsonProperty("start_time")]
        public int StartTime;

        [JsonProperty("duration")]
        public int Duration;

        [JsonProperty("cluster")]
        public int Cluster;

        [JsonProperty("lobby_type")]
        public int LobbyType;

        [JsonProperty("game_mode")]
        public int GameMode;

        [JsonProperty("is_contributor")]
        public bool IsContributor;

        [JsonProperty("patch")]
        public int Patch;

        [JsonProperty("region")]
        public int Region;

        [JsonProperty("isRadiant")]
        public bool IsRadiant;

        [JsonProperty("win")]
        public int Win;

        [JsonProperty("lose")]
        public int Lose;

        [JsonProperty("total_gold")]
        public int TotalGold;

        [JsonProperty("total_xp")]
        public int TotalXp;

        [JsonProperty("kills_per_min")]
        public double KillsPerMin;

        [JsonProperty("kda")]
        public int Kda;

        [JsonProperty("abandons")]
        public int Abandons;

        [JsonProperty("rank_tier")]
        public int? RankTier;

        [JsonProperty("cosmetics")]
        public List<object> Cosmetics;

        [JsonProperty("benchmarks")]
        public Benchmarks Benchmarks;
    }

    public class MatchDTO
    {
        [JsonProperty("match_id")]
        public int MatchId;

        [JsonProperty("barracks_status_dire")]
        public int BarracksStatusDire;

        [JsonProperty("barracks_status_radiant")]
        public int BarracksStatusRadiant;

        [JsonProperty("chat")]
        public object Chat;

        [JsonProperty("cluster")]
        public int Cluster;

        [JsonProperty("cosmetics")]
        public object Cosmetics;

        [JsonProperty("dire_score")]
        public object DireScore;

        [JsonProperty("dire_team_id")]
        public object DireTeamId;

        [JsonProperty("draft_timings")]
        public object DraftTimings;

        [JsonProperty("duration")]
        public int Duration;

        [JsonProperty("engine")]
        public int Engine;

        [JsonProperty("first_blood_time")]
        public int FirstBloodTime;

        [JsonProperty("game_mode")]
        public int GameMode;

        [JsonProperty("human_players")]
        public int HumanPlayers;

        [JsonProperty("leagueid")]
        public int Leagueid;

        [JsonProperty("lobby_type")]
        public int LobbyType;

        [JsonProperty("match_seq_num")]
        public int MatchSeqNum;

        [JsonProperty("negative_votes")]
        public int NegativeVotes;

        [JsonProperty("objectives")]
        public object Objectives;

        [JsonProperty("picks_bans")]
        public object PicksBans;

        [JsonProperty("positive_votes")]
        public int PositiveVotes;

        [JsonProperty("radiant_gold_adv")]
        public object RadiantGoldAdv;

        [JsonProperty("radiant_score")]
        public object RadiantScore;

        [JsonProperty("radiant_team_id")]
        public object RadiantTeamId;

        [JsonProperty("radiant_win")]
        public bool RadiantWin;

        [JsonProperty("radiant_xp_adv")]
        public object RadiantXpAdv;

        [JsonProperty("skill")]
        public object Skill;

        [JsonProperty("start_time")]
        public int StartTime;

        [JsonProperty("teamfights")]
        public object Teamfights;

        [JsonProperty("tower_status_dire")]
        public int TowerStatusDire;

        [JsonProperty("tower_status_radiant")]
        public int TowerStatusRadiant;

        [JsonProperty("version")]
        public object Version;

        [JsonProperty("players")]
        public List<Player> Players;

        [JsonProperty("patch")]
        public int Patch;

        [JsonProperty("region")]
        public int Region;
    }

}