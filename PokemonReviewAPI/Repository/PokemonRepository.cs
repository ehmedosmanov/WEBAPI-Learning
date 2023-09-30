using PokemonReviewAPI.Data;
using PokemonReviewAPI.Interfaces;
using PokemonReviewAPI.Models;

namespace PokemonReviewAPI.Repository
{
    public class PokemonRepository:IPokemonRepository
    {
        private readonly AppDbContext _db;
        public PokemonRepository(AppDbContext db)
        {
            _db = db;
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _db.Pokemons.OrderBy(p => p.Id).ToList();
        }
    }
}
