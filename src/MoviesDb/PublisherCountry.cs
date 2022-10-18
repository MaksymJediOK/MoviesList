using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesCore
{
    public class PublisherCountry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? CountryName { get; set; }

        public List<Movie>? Movies { get; set; }

        public override string ToString()
        {
            return $"{CountryName}";
        }
    }
}
