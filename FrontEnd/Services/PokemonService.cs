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

            //foreach (var entry in listResponse.Results)
            //{
            //    var detailsResponse = await _httpClient.GetAsync(entry.Url);
            //    if (detailsResponse == null || !detailsResponse.IsSuccessStatusCode) throw new Exception($"Failed to fetch details for {entry.Name} - StatusCode: {detailsResponse?.StatusCode}");
            //    //if (!detailsResponse.IsSuccessStatusCode) continue;

            //    var detailsContent = await detailsResponse.Content.ReadAsStringAsync();

            //    // ✅ Ahora deserializamos directamente al modelo
            //    var pokemon = JsonConvert.DeserializeObject<Pokemon>(detailsContent);

            //    // ✅ Validación básica por si falla la deserialización
            //    if (pokemon != null)
            //    {
            //        pokemons.Add(pokemon);
            //    }            
            //}

            //return pokemons;
            var tasks = listResponse.Results.Select(async entry =>
            {
                var detailsResponse = await _httpClient.GetAsync(entry.Url);
                if (!detailsResponse.IsSuccessStatusCode) return null;

                var detailsContent = await detailsResponse.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Pokemon>(detailsContent);
            });

            var results = await Task.WhenAll(tasks);
            return results.Where(p => p != null).ToList();

        }

        public async Task<Pokemon?> GetPokemonByNameAsync(string name)
        {
            var response = await _httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{name}");
            if (!response.IsSuccessStatusCode) throw new Exception($"Failed to fetch details for the pokemon- StatusCode: {response?.StatusCode}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Pokemon>(content);
        }
    }
}
