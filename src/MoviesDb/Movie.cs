using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesCore
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? PosterPath { get; set; }

        public float? Rating { get; set; }
        public int ReleaseYear { get; set; }
        public int Duration { get; set; }

        public List<Genre>? Genres { get; set; }
        public List<Director>? Directors { get; set; }

        public List<Actor>? Actors { get; set; }

        public override string ToString()
        {
            return $"{Title}";
        }
    }
}
