namespace SuperHeroWebAPIWithDotNet7.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHero> GetAllSuperHeroes();
        SuperHero? GetSingleHero(int id);
        List<SuperHero> AddHero(SuperHero hero);
        List<SuperHero>? UpdateHero(int id, SuperHero request);
        List<SuperHero>? DeleteHero(int id);
    }
}
