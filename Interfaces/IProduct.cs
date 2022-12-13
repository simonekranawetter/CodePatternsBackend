using System.ComponentModel.DataAnnotations;

namespace CodePatternsBackend.Interfaces
{// TODO COMMENT THIS INTERFACE SEGGREGATION
    public interface IProduct
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Picture { get; set; }
        public string ProductName { get; set; } 
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
