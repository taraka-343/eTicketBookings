using eTicketBookings.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketBookings.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.actorId,
                am.movieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.actor_movie).HasForeignKey(m => m.movieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.actor_movie).HasForeignKey(m => m.actorId);


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Producer> producer { get; set; }
        public DbSet<Actor> actor { get; set; }

        public DbSet<Movie> movie { get; set; }

        public DbSet<Cinema> cinema { get; set; }

        public DbSet<Actor_Movie> actor_movie { get; set; }

    }
}
