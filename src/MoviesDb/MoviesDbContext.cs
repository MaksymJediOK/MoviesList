﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MoviesCore
{
    public class MoviesDbContext : IdentityDbContext<User>
    {

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Movie>()
                .HasMany(x => x.Genres)
                .WithMany(x => x.Movies);

            builder.Entity<Movie>()
                .HasMany(x => x.Directors)
                .WithMany(x => x.Movies);

            builder.Entity<Movie>()
                .HasMany(x => x.Actors)
                .WithMany(x => x.Movies);
            builder.Seed();
            base.OnModelCreating(builder);
        }
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options)
            : base(options)
        {

        }

    
        public DbSet<Movie>? Movies { get; set; }
        public DbSet<Genre>? Genres { get; set; }
        public DbSet<Director>? Directors { get; set; }
        public DbSet<PublisherCountry>? PublisherCountries { get; set; }
        public DbSet<Actor>? Actors { get; set; }
    }
}