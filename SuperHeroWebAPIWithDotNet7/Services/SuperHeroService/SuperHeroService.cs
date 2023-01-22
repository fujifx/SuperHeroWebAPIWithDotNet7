namespace SuperHeroWebAPIWithDotNet7.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeroes = new List<SuperHero> {
                new SuperHero
                {
                    Id = 1,
                    Name = "Spider Man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York City"
                },
                new SuperHero
                {
                    Id = 2,
                    Name = "Iron Man",
                    FirstName = "Tony",
                    LastName = "Stark",
                    Place = "Malibu"
                },
            };

        public List<SuperHero> AddHero(SuperHero hero)
        {
            superHeroes.Add(hero);
            return superHeroes;
        }

        public List<SuperHero>? DeleteHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);

            if (hero == null)
                return null;

            superHeroes.Remove(hero);

            return superHeroes;
        }

        public List<SuperHero> GetAllSuperHeroes()
        {
            return superHeroes;
        }

        public SuperHero? GetSingleHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);

            if (hero == null)
                return null;

            return hero;
        }

        public List<SuperHero>? UpdateHero(int id, SuperHero request)
        {
            var hero = superHeroes.Find(x => x.Id == id);

            if (hero == null)
                return null;

            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;
            hero.Name = request.Name;

            return superHeroes;
        }
    }
}
