using Newtonsoft.Json;

namespace DotaProject
{
    public class HeroeDTO
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("localized_name")]
        public string LocalizedName { get; set; }

        [JsonProperty("primary_attr")]
        public string PrimaryAttr { get; set; }

        [JsonProperty("attack_type")]
        public string AttackType { get; set; }

        [JsonProperty("roles")]
        public List<string> Roles { get; set; }
    }
}