using System.ComponentModel.DataAnnotations;

namespace CodePatternsBackend.Interfaces
{   // INTERFACE SEGGREGATION
    // To be fair, for a tiny little project like this I would not have made interfaces at all, since the project is more DRY without it, but just to have somewhere to put this comment, I made a product interface
    public interface IProduct
    {
        public int Rating { get; set; }
        public string Picture { get; set; }
        public string ProductName { get; set; } 
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
