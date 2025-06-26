using FrontEnd.Models;
using FrontEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class PokemonController : Controller
    {
        private readonly IPokemonService _pokemonService;

        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        public async Task<IActionResult> Index()
        {
            var pokemons = await _pokemonService.GetPokemonsAsync(25);
            return View(pokemons);
        }

        public async Task<IActionResult> Details(string name)
        {
            var pokemon = await _pokemonService.GetPokemonByNameAsync(name);
            //if (string.IsNullOrEmpty(name))
            //{
            //    return NotFound();
            //}
            //var pokemon = await _pokemonService.GetPokemonByNameAsync(name);
            //if (pokemon == null)
            //{
            //    return NotFound();
            //}
            return View(pokemon);
        }
    }
}
