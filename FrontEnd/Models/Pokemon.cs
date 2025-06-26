using Newtonsoft.Json;
using System.Reflection;

namespace FrontEnd.Models
{
    public class PokemonListResponse
    {
        public List<PokemonEntry> Results { get; set; } = new();
    }

    public class PokemonEntry
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
    }

    public class Pokemon
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Sprites? Sprites { get; set; }
        public List<TypeWrapper> Types { get; set; } = new();
        public List<AbilityWrapper> Abilities { get; set; } = new();
        public List<StatsWrapper> Stats { get; set; } = new();
    }

    public class Sprites
    {
        [JsonProperty("front_default")]
        public string? FrontDefault { get; set; }
    }
    public class TypeWrapper
    {
        public TypeInfo? Type { get; set; }
    }
    public class TypeInfo
    {
        [JsonProperty ("name")]
        public string? Name { get; set; }
    }
    public class AbilityWrapper
    {
        public AbilityInfo? Ability { get; set; }
    }
    public class AbilityInfo
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
    public class StatsWrapper
    {
        [JsonProperty("base_stat")]
        public int BaseStat { get; set; }
        [JsonProperty("effort")]
        public int Effort { get; set; }
        public StatsInfo? Stat { get; set; }
    }
    public class StatsInfo
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
