namespace SkumOgSandhed.Domain
{
    public class Beer
    {
        public int BeerId { get; set; }
        public int ReleaseYear { get; set; }
        public int DrinkingYear { get; set; }
        public decimal Abv { get; set; }
        public string FoodPairing { get; set; }
        public string Description { get; set; }
        public string Fermentation { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
        public int UntappdRating { get; set; }
    }
}