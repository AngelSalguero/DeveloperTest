using FrontEnd.Models;

namespace FrontEnd.Services
{
    public interface IPokemonService
    {
        Task<List<Pokemon>> GetPokemonsAsync(int limit);
    }

}
