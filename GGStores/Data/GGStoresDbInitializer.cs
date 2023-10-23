using GGStores.Data.Enum;
using GGStores.Models;

namespace GGStores.Data
{
    public class GGStoresDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<StoreDbContext>();
                context.Database.EnsureCreated();

                if (!context.cinema.Any())
                {
                    context.cinema.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },

                         new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                         new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                         new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                          new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },

                    });
                    context.SaveChanges();

                }
                context.SaveChanges();
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<ActorModel>()
                    {
                        new ActorModel()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePicture = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },

                         new ActorModel()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePicture = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                          new ActorModel()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the third actor",
                            ProfilePicture = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                           new ActorModel()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the fourth actor",
                            ProfilePicture = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                            new ActorModel()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the fifth actor",
                            ProfilePicture = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                }
                context.SaveChanges();
                if (!context.producer.Any())
                {
                    context.producer.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = " This is the Bio of the First producer",
                            ProfilePicture = "http://dotnetnow.net/images/producers/producer-1.jpeg"

                        },
                          new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = " This is the Bio of the Second producer",
                            ProfilePicture = "http://dotnetnow.net/images/producers/producer-2.jpeg"

                        },
                            new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = " This is the Bio of the Third producer",
                            ProfilePicture = "http://dotnetnow.net/images/producers/producer-3.jpeg"

                        },
                              new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = " This is the Bio of the Fourth producer",
                            ProfilePicture = "http://dotnetnow.net/images/producers/producer-4.jpeg"

                        },
                                new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = " This is the Bio of the Fifth producer",
                            ProfilePicture = "http://dotnetnow.net/images/producers/producer-5.jpeg"

                        }
                    });
                }
                context.SaveChanges();
                if (!context.Movie.Any())
                {
                    context.Movie.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                           Name = "Queen of the damned",
                           Description = "The vampire movie",
                           Price = 20.00,
                           ImageUrl = "https://th.bing.com/th/id/R.6ed7571022166733b8408cfc7493fd9a?rik=JXKeuuBnZM9tJg&riu=http%3a%2f%2fimages1.fanpop.com%2fimages%2fphotos%2f1500000%2fQueen-of-the-Damned-queen-of-the-damned-1577326-1024-768.jpg&ehk=mEdupDx%2bqoaVy49LcX7HG4yUd%2f2NR%2f6IHHUa7dHGkag%3d&risl=&pid=ImgRaw&r=0",
                           StartDate = DateTime.Now.AddDays(3),
                           EndDate = DateTime.Now.AddDays(20),
                           CinemaId = 1,
                           ProducerId = 1,
                           MovieCategory = MovieCategory.Action
                        },
                          new Movie()
                        {
                           Name = "One Piece",
                           Description = "The pirates movie",
                           Price = 20.00,
                           ImageUrl = "https://th.bing.com/th/id/R.bee882924d9843831ef74998765c81dd?rik=qadffM3OSa1Acw&riu=http%3a%2f%2f4.bp.blogspot.com%2f-B74rQuM_f9A%2fT-BeOFJugyI%2fAAAAAAAAA2s%2f2xHp01DEVKo%2fs1600%2fone-piece-film-strong-world-poster.jpg&ehk=0XdmO2pcehRp0NQ7kbVVICdI7upolaqEkpC81J%2bA008%3d&risl=&pid=ImgRaw&r=0",
                           StartDate = DateTime.Now.AddDays(10),
                           EndDate = DateTime.Now.AddDays(29),
                           CinemaId = 1,
                           ProducerId = 2,
                           MovieCategory = MovieCategory.Cartoon
                        },
                            new Movie()
                        {
                           Name = "Harry Potter",
                           Description = "The Boy who lived",
                           Price = 20.00,
                           ImageUrl = "https://th.bing.com/th/id/R.e82a05e938485d7a00d4d2623c802ef1?rik=PN8iXbWoyvgSIQ&riu=http%3a%2f%2fimages5.fanpop.com%2fimage%2fphotos%2f29000000%2fharry-potter-harry-potter-29097111-1024-768.jpg&ehk=7aOhogfreKFVg5qfXVTZk6URPDMgwYfUHlcdSEaZjwQ%3d&risl=&pid=ImgRaw&r=0",
                           StartDate = DateTime.Now.AddDays(-3),
                           EndDate = DateTime.Now.AddDays(20),
                           CinemaId = 1,
                           ProducerId = 3,
                           MovieCategory = MovieCategory.Drama
                        },
                              new Movie()
                        {
                           Name = "Pirates of the carribean",
                           Description = "The pirates movie",
                           Price = 20.00,
                           ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/a560ec764392d78eb778437ae1e9a2a5.jpg",
                           StartDate = DateTime.Now.AddDays(7),
                           EndDate = DateTime.Now.AddDays(27),
                           CinemaId = 1,
                           ProducerId = 4,
                           MovieCategory = MovieCategory.Action
                        },
                                new Movie()
                        {
                           Name = "Kingdom of Heaven",
                           Description = "The war movie",
                           Price = 20.00,
                           ImageUrl = "https://th.bing.com/th/id/R.32cd4a9f21f1da0305e22729ac9cf580?rik=mxko1TuiwOOA3A&pid=ImgRaw&r=0",
                           StartDate = DateTime.Now.AddDays(-3),
                           EndDate = DateTime.Now.AddDays(28),
                           CinemaId = 1,
                           ProducerId = 5,
                           MovieCategory = MovieCategory.Action
                        }

                    });
                }
                context.SaveChanges();
                if (!context.Actor_Movie.Any())
                {
                    context.Actor_Movie.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            Movieid = 1,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            Movieid = 4,
                        },
                         new Actor_Movie()
                        {
                            ActorId = 3,
                            Movieid = 4,
                        },
                          new Actor_Movie()
                        {
                            ActorId = 4,
                            Movieid = 2,
                        },
                           new Actor_Movie()
                        {
                            ActorId = 5,
                            Movieid = 5,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            Movieid = 4,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            Movieid = 5,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            Movieid = 3,
                        },
                         new Actor_Movie()
                        {
                            ActorId = 5,
                            Movieid = 4,
                        },

                    });
                }
                context.SaveChanges();
            }
        }
    }
}
