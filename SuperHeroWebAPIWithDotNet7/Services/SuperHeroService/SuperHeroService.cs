using Microsoft.EntityFrameworkCore;

namespace SuperHeroWebAPIWithDotNet7.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        //private static List<SuperHero> superHeroes = new List<SuperHero> {
        //        new SuperHero
        //        {
        //            Id = 1,
        //            Name = "Spider Man",
        //            FirstName = "Peter",
        //            LastName = "Parker",
        //            Place = "New York City"
        //        },
        //        new SuperHero
        //        {
        //            Id = 2,
        //            Name = "Iron Man",
        //            FirstName = "Tony",
        //            LastName = "Stark",
        //            Place = "Malibu"
        //        },
        //    };
        private readonly DataContext _dataContext;

        public SuperHeroService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<SuperHero>> AddHero(SuperHero hero)
        {
            _dataContext.SuperHeroes.Add(hero);
            await _dataContext.SaveChangesAsync();
            return await _dataContext.SuperHeroes.ToListAsync();
        }

        public async Task<List<SuperHero>?> DeleteHero(int id)
        {
            var hero = await _dataContext.SuperHeroes.FindAsync(id);

            if (hero == null)
                return null;

            _dataContext.SuperHeroes.Remove(hero);
            await _dataContext.SaveChangesAsync();

            return await _dataContext.SuperHeroes.ToListAsync();
        }

        public async Task<List<SuperHero>> GetAllSuperHeroes()
        {
            var superHeroes = await _dataContext.SuperHeroes.ToListAsync();
            return superHeroes;
        }

        public async Task<SuperHero?> GetSingleHero(int id)
        {
            var hero = await _dataContext.SuperHeroes.FindAsync(id);

            if (hero == null)
                return null;

            return hero;
        }

        public async Task<List<SuperHero>?> UpdateHero(int id, SuperHero request)
        {
            var hero = await _dataContext.SuperHeroes.FindAsync(id);

            if (hero == null)
                return null;

            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;
            hero.Name = request.Name;

            await _dataContext.SaveChangesAsync();

            return await _dataContext.SuperHeroes.ToListAsync();
        }
    }
}
