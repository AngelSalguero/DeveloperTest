using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly HttpClient _httpClient;

        public PokemonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Pokemon>> GetPokemonsAsync(int limit)
        {
            var response = await _httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon?limit={limit}");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var listResponse = JsonConvert.DeserializeObject<PokemonListResponse>(content);

            if (listResponse == null)
                throw new Exception("Failed to deserialize Pokemon list response.");

            var pokemons = new List<Pokemon>();

            foreach (var entry in listResponse.Results)
            {
                var detailsResponse = await _httpClient.GetAsync(entry.Url);
                if (detailsResponse == null || !detailsResponse.IsSuccessStatusCode) throw new Exception("The value is not accepted");
                if (!detailsResponse.IsSuccessStatusCode) continue;

                var detailsContent = await detailsResponse.Content.ReadAsStringAsync();
                dynamic pokeJson = JsonConvert.DeserializeObject(detailsContent);

                var pokemon = new Pokemon
                {
                    Id = pokeJson.id,
                    Name = pokeJson.name,
                    ImageUrl = pokeJson.sprites.front_default,
                    Types = ((IEnumerable<dynamic>)pokeJson.types)
                            .Select(t => (string)t.type.name)
                            .ToList()
                };

                pokemons.Add(pokemon);
            }

            return pokemons;
        }
    }
}
