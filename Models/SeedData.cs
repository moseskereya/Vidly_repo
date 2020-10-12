using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Data;

namespace Vidly.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MovieContext>>()))
            {
                if (context.Movie.Any() && context.Products.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "When Harry Met Sally",
                         ReleaseDate = DateTime.Parse("1989-2-12"),
                         Genre = "Romantic Comedy",
                         Price = 7.99M,
                         Description = "Harry and Sally meet when she gives him a ride to New York after they both graduate from the University of Chicago. The film jumps through their lives as they both search for love, but fail, bumping into each other time and time again. Finally a close friendship blooms between them, and they both like having a friend of the opposite sex",
                         Img = "m1.jpg"
                     },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Description = "Ghostbusters is a 1984 American supernatural comedy film directed by Ivan Reitman and written by Dan Aykroyd and Harold Ramis.It stars Bill Murray, Aykroyd, and Ramis as, respectively, Peter Venkman, Ray Stantz, and Egon Spengler, a trio of eccentric parapsychologists who start a ghost-catching business in New York City",
                        Img = "m2.jpg"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Description = "Ghostbusters 2 is a 2000 American supernatural comedy film directed by Ivan Reitman and written by Dan Aykroyd and Harold Ramis.It stars Bill Murray, Aykroyd, and Ramis as, respectively, Peter Venkman, Ray Stantz, and Egon Spengler, a trio of eccentric parapsychologists who start a ghost-catching business in New York City",
                        Img = "m3.jpg"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Description = "Rio Bravo is a 1959 American Western film produced and directed by Howard Hawks and starring John Wayne, Dean Martin, Ricky Nelson, Angie Dickinson, Walter Brennan, and Ward Bond. Written by Jules Furthman and Leigh Brackett, based on the short story 'Rio Bravo' by B. H. McCampbell, the film is about the sheriff of the town of Rio Bravo, Texas, who arrests the brother of a powerful local rancher for murder and then must hold the man in jail until the arrival of the United States Marshall.",
                        Img = "m4.jpg"
                    }

                  );
                 context.SaveChanges();


                context.Products.AddRange(
                    new Product
                    {
                        Maker = "@jenlooper",
                        Image = "https://images.pexels.com/photos/1030946/pexels-photo-1030946.jpeg?auto=compress\u0026cs=tinysrgb\u0026dpr=1\u0026w=500",
                        Url = "https://www.pexels.com/photo/close-up-photo-of-three-sweatshirts-1030946",
                        Title = "The Quantified natural make clothes for both boys and girls",
                        Description = "This project is a good learning project to get comfortable with soldering and programming an Arduino."
                    },
                     new Product
                     {
                         Maker = "@jenlooper",
                         Image = "https://user-images.githubusercontent.com/41929050/61567048-13938600-aa33-11e9-9cfd-712191013192.jpeg",
                         Url = "https://www.hackster.io/agent-hawking-1/the-quantified-cactus-an-easy-plant-soil-moisture-sensor-e65393",
                         Title = "The Quantified Cactus: An Easy Plant Soil Moisture Sensor",
                         Description = "This project is a good learning project to get comfortable with soldering and programming an Arduino."
                     },
                      new Product
                      {

                        Maker  = "@jenlooper",
                        Image  = "https://user-images.githubusercontent.com/41929050/61567053-13938600-aa33-11e9-9780-104fe4019659.png",
                        Url  = "https://www.hackster.io/agent-hawking-1/bling-your-laptop-with-an-internet-connected-light-show-30e4db",
                        Title  = "Bling your Laptop with an Internet-Connected Light Show",
                        Description  = "Create a web-connected light-strip API controllable from your website, using the Particle.io."
                       },
                    new Product
                    {

                    Maker  = "jenlooper",
                    Image  = "https://user-images.githubusercontent.com/41929050/61567051-13938600-aa33-11e9-8ae7-0b5c19aafab4.jpeg",
                    Url  = "https://www.hackster.io/agent-hawking-1/create-a-compact-survival-kit-38bfdb",
                    Title  = "Create a Compact Survival Kit with LED Track Lighting",
                    Description  = "Use an Altoids tin with Chibitronics sticker LEDs to create a light-up compact that doubles as a survival kit for the young hipster",

                    },
                    new Product
                    {
               
                    Maker  = "sailorhg",
                    Image  = "https://user-images.githubusercontent.com/41929050/61567054-13938600-aa33-11e9-9163-eec98e239b7a.png",
                    Url  = "https://twitter.com/sailorhg/status/1090107740049952770",
                    Title  = "Bubblesort Visualization",
                    Description  = "Visualization of sailor scouts sorted by bubblesort algorithm by their planet\u0027s distance from the sun",
                    },

                    new Product
                    {

                    Maker  = "sailorhg",
                    Image  = "https://user-images.githubusercontent.com/41929050/61567055-142c1c80-aa33-11e9-96ff-9fbac6413625.png",
                    Url  = "https://twitter.com/sailorhg/status/1090113666911891456",
                    Title  = "Light-up Corsage",
                    Description  = "Light-up corsage I made with my summer intern.",
                   
                    },
                    new Product
                    {
                    Maker  = "sailorhg",
                    Image  = "https://user-images.githubusercontent.com/41929050/61567056-142c1c80-aa33-11e9-8682-10065d338145.png",
                    Url  = "https://twitter.com/sailorhg/status/1090122822007963648",
                    Title  = "Pastel hardware kit",
                    Description  = "Pastel hardware kits complete with custom manufactured pastel alligator clips.",
                    },
                    new Product 
                   { 
                    Maker  = "sailorhg",
                   Image  = "https://user-images.githubusercontent.com/41929050/61567052-13938600-aa33-11e9-9a88-cd842073ba44.jpg",
                    Url  = "https://twitter.com/sailorhg/status/1090117277540745216",
                   Title  = "Heart-shaped LED",
                    Description =  "custom molded heart shaped LED with sprinkles.",
                    },
                    new Product
                    {
                   Maker = "selinazawacki",
                   Image = "https://user-images.githubusercontent.com/41929050/61567060-142c1c80-aa33-11e9-8188-5a4803844a9e.png",
                   Url  ="https://www.instagram.com/p/BNvESj-j8PI/",
                   Title = "Black Sweatshirt",
                   Description ="Black sweatshirt hoody with the Sick of the Internet logo.",
                    },
                    new Product
                    { 
                    Maker =  "selinazawacki",
                    Image =  "https://user-images.githubusercontent.com/41929050/61567059-142c1c80-aa33-11e9-939b-2ecf4492786d.png",
                    Url =  "https://www.instagram.com/p/BNm6hZzDoEF/",
                    Title =  "Sick of the Internet Pins",
                    Description =  "Still some time to enter the pin/sticker giveaway! ",
                    },

                    new Product
                    {      
                        Maker = "selinazawacki",
                        Image = "https://user-images.githubusercontent.com/41929050/61567058-142c1c80-aa33-11e9-89fb-b4f30d84d69d.png",
                        Url ="https://www.instagram.com/p/BEXlpiZCnJ3/",
                        Title =  "Floppy Crop",
                        Description ="Used up the Diskette fabric today to make 2 of these crops.",
                     },

                     new Product
                     {
                      Maker = "selinazawacki",
                      Image ="https://user-images.githubusercontent.com/41929050/61567057-142c1c80-aa33-11e9-9781-9e442418eaab.png",
                     Url = "https://www.instagram.com/p/BFktVYPinKQ/",
                     Title = "Holographic Dark Moon Necklace",
                     Description = "Not sure if I\u0027ll be making more, get it while I have it in the store.",
                     },

                      new Product
                      {
                        Maker = "vogueandcode",
                        Image = "https://user-images.githubusercontent.com/41929050/61567063-14c4b300-aa33-11e9-8515-bcb866da9ea3.png",
                        Url = "https://www.vogueandcode.com/shop/ruby-sis-2",
                        Title = "Ruby Sis",
                        Description =  "Styled in a dashiki, Ruby Sis is listening to music while coding in her favorite language, Ruby!",
                      },
                       new Product
                       {
                            Maker = "vogueandcode",
                            Image = "https://user-images.githubusercontent.com/41929050/61567061-14c4b300-aa33-11e9-9fee-63ff2c0c9823.png",
                            Url = "https://www.vogueandcode.com/shop/hipster-dev-bro",
                            Title = "Hipster Dev",
                           Description =  "Hipster Dev is busy coding away while styled in a camo jacket and orange beanie.",
                       }
                    );
                context.SaveChanges();
                 
            }
        }
    }
}
