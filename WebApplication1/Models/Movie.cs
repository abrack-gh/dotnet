using System;

namespace WebApplication1.Models
{
    public class Movie
    {
       public int id { get; set; }
       public string Title { get; set; }
       public DateTime ReleaseDate { get; set; }
       public string Genre { get; set; }
       public Decimal Price { get; set; }
       public int AgeRating { get; set; }
    }
}