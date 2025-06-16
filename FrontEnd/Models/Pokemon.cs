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
        public List<string> Types { get; set; } = new();
        public string? ImageUrl { get; set; }
    }
}
