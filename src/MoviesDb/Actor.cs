using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MoviesCore
{
    public class Actor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? PhotoPath { get; set; }
        public List<Movie>? Movies { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ";
        }
    }
}
