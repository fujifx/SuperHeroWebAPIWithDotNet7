namespace SuperHeroWebAPIWithDotNet7.Models
{
    public class HeroTeam
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public SuperHero? SuperHero { get; set; }
    }
}
