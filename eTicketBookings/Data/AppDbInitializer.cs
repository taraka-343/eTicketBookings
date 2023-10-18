using eTicketBookings.Data.Enumurators;
using eTicketBookings.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketBookings.Data
{
    public class AppDbInitializer
    {
        public static void seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope= applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //cinema
                if (!context.cinema.Any())
                {
                    context.cinema.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();

                }
                //actor
                if (!context.actor.Any())
                {
                    context.actor.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            fullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            profilePictureUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            fullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            profilePictureUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            fullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            profilePictureUrl = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            fullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            profilePictureUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            fullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            profilePictureUrl = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //producer
                if (!context.producer.Any())
                {
                    context.producer.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            fullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            profilePictureUrl = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            fullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            profilePictureUrl = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            fullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            profilePictureUrl = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            fullName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            profilePictureUrl = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            fullName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            profilePictureUrl = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //movie
                if (!context.movie.Any())
                {
                    context.movie.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            price = 39.50,
                            imageUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            startDate = DateTime.Now.AddDays(-10),
                            endDate = DateTime.Now.AddDays(10),
                            cinemaId = 3,
                            producerId = 3,
                            movieCategory = movieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            price = 29.50,
                            imageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            startDate = DateTime.Now,
                            endDate = DateTime.Now.AddDays(3),
                            cinemaId = 1,
                            producerId = 1,
                            movieCategory = movieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            price = 39.50,
                            imageUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            startDate = DateTime.Now,
                            endDate = DateTime.Now.AddDays(7),
                            cinemaId = 4,
                            producerId = 4,
                            movieCategory = movieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            price = 39.50,
                            imageUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            startDate = DateTime.Now.AddDays(-10),
                            endDate = DateTime.Now.AddDays(-5),
                            cinemaId = 1,
                            producerId = 2,
                            movieCategory = movieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            price = 39.50,
                            imageUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            startDate = DateTime.Now.AddDays(-10),
                            endDate = DateTime.Now.AddDays(-2),
                            cinemaId = 1,
                            producerId = 3,
                            movieCategory = movieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            price = 39.50,
                            imageUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            startDate = DateTime.Now.AddDays(3),
                            endDate = DateTime.Now.AddDays(20),
                            cinemaId = 1,
                            producerId = 5,
                            movieCategory = movieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //actor-movie
                if (!context.actor_movie.Any())
                {
                    context.actor_movie.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            actorId = 1,
                            movieId = 1
                        },
                        new Actor_Movie()
                        {
                            actorId = 3,
                            movieId = 1
                        },

                         new Actor_Movie()
                        {
                            actorId = 1,
                            movieId = 2
                        },
                         new Actor_Movie()
                        {
                            actorId = 4,
                            movieId = 2
                        },

                        new Actor_Movie()
                        {
                            actorId = 1,
                            movieId = 3
                        },
                        new Actor_Movie()
                        {
                            actorId = 2,
                            movieId = 3
                        },
                        new Actor_Movie()
                        {
                            actorId = 5,
                            movieId = 3
                        },


                        new Actor_Movie()
                        {
                            actorId = 2,
                            movieId = 4
                        },
                        new Actor_Movie()
                        {
                            actorId = 3,
                            movieId = 4
                        },
                        new Actor_Movie()
                        {
                            actorId = 4,
                            movieId = 4
                        },


                        new Actor_Movie()
                        {
                            actorId = 2,
                            movieId = 5
                        },
                        new Actor_Movie()
                        {
                            actorId = 3,
                            movieId = 5
                        },
                        new Actor_Movie()
                        {
                            actorId = 4,
                            movieId = 5
                        },
                        new Actor_Movie()
                        {
                            actorId = 5,
                            movieId = 5
                        },


                        new Actor_Movie()
                        {
                            actorId = 3,
                            movieId = 6
                        },
                        new Actor_Movie()
                        {
                            actorId = 4,
                            movieId = 6
                        },
                        new Actor_Movie()
                        {
                            actorId = 5,
                            movieId = 6
                        },
                    });
                    context.SaveChanges();
                
            }
            }

        }
    }
}
