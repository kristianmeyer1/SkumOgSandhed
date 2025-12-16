namespace SkumOgSandhed.Domain.Entities
{
    public class Beer
    {
        public int BeerId { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public int DrinkingYear { get; set; }
        public decimal Abv { get; set; }
        public string FoodPairing { get; set; }
        public string Description { get; set; }
        public string Fermentation { get; set; }
        public string YeastType { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
        public decimal UntappdRating { get; set; }
    }
}