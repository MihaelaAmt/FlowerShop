using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerApp.Models
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                AppDbContext context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(Categories.Select(c => c.Value));
                }

                if (!context.Flowers.Any())
                {
                    context.AddRange
                    (
                        new Flower
                        {
                            Name = "Lily",
                            Price = 12.95M,
                            ShortDescription = "Strong smell",
                            LongDescription = @"sdfdgr",
                            Category = Categories["Single flower"],
                            ImageUrl = "https://www.florariaaly.ro/image/cache/data/Flori%20la%20fir/Crin%20imperial-500x500_0.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "https://www.florariaaly.ro/image/cache/data/Flori%20la%20fir/Crin%20imperial-500x500_0.jpg"
                        },
                        new Flower
                        {
                            Name = "Rose",
                            Price = 18.95M,
                            ShortDescription = "Roses is beautiful!",
                            LongDescription = "fdfhdfhf",
                            Category = Categories["Single flower"],
                            ImageUrl = "http://www.buchetetrandafiri.ro/poze/flori/un-fir-de-trandafir-rosu-OBIdz.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "http://www.buchetetrandafiri.ro/poze/flori/un-fir-de-trandafir-rosu-OBIdz.jpg"
                        },
                        new Flower
                        {
                            Name = "Daisy",
                            Price = 18.95M,
                            ShortDescription = "White daisy flower",
                            LongDescription = "ssdgdfdf",
                            Category = Categories["Single flower"],
                            ImageUrl = "https://i.pinimg.com/originals/17/a5/d1/17a5d17b2f30c1ad24b6fd182dc89c59.jpg",
                            InStock = true, ImageThumbnailUrl = "https://i.pinimg.com/originals/17/a5/d1/17a5d17b2f30c1ad24b6fd182dc89c59.jpg"
                        },
                        new Flower
                        {
                            Name = "Bouquet of roses",
                            Price = 15.95M,
                            ShortDescription = "101 roses",
                            LongDescription = "cfghfd",
                            Category = Categories["Bouquet of flowers"],
                            ImageUrl = "https://florariadevis.ro/1493-large_default/buchet-trandafiri.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "https://florariadevis.ro/1493-large_default/buchet-trandafiri.jpg"
                        },

                        new Flower {
                            Name = "Hyacinth",
                            Price = 13.95M,
                            ShortDescription = "Spring flower",
                            LongDescription = "dfgdfg",
                            Category = Categories["Seasonal flowers"],
                            ImageUrl = "https://www.giftidea.ro/wp-content/uploads/2017/02/3-1.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "https://www.giftidea.ro/wp-content/uploads/2017/02/3-1.jpg"
                        },

                        new Flower {
                            Name = "Tulip",
                            Price = 17.95M,
                            ShortDescription = "Spring flower",
                            LongDescription = "dsfsd",
                            Category = Categories["Seasonal flowers"],
                            ImageUrl = "https://floridebrasov.ro/pics/6/0.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "https://floridebrasov.ro/pics/6/0.jpg"
                        },

                        new Flower {
                            Name = "Bouquet of field flowers",
                            Price = 15.95M,
                            ShortDescription = "Field flowers",
                            LongDescription = "jxhcjksdh",
                            Category = Categories["Bouquet of flowers"],
                            ImageUrl = "https://www.magnolia.ro/images/products/1562829074img_7543.jpg",
                            InStock = false,
                            ImageThumbnailUrl = "https://www.magnolia.ro/images/products/1562829074img_7543.jpg"
                        },

                        new Flower {
                            Name = "Pearl",
                            Price = 12.95M,
                            ShortDescription = "For lovers of spring",
                            LongDescription = "vsdds",
                            Category = Categories["Seasonal flowers"],
                            ImageUrl = "https://s12emagst.akamaized.net/products/3599/3598987/images/res_6664a230d1124f1cbe0eb246f0c7a477_full.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "https://s12emagst.akamaized.net/products/3599/3598987/images/res_6664a230d1124f1cbe0eb246f0c7a477_full.jpg"
                        },

                        new Flower {
                            Name = "Peony bouquet",
                            Price = 15.95M,
                            ShortDescription = "King in the spring garden",
                            LongDescription = "xvdfg",
                            Category = Categories["Bouquet of flowers"],
                            ImageUrl = "https://s12emagst.akamaized.net/products/6085/6084226/images/res_b401ee11c47ba7fb3762c91794496f22_full.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "https://s12emagst.akamaized.net/products/6085/6084226/images/res_b401ee11c47ba7fb3762c91794496f22_full.jpg"
                        },
                        new Flower {
                            Name = "Bouquet of lilies",
                            Price = 15.95M,
                            ShortDescription = "Strong flower",
                            LongDescription = "gfdgdgd",
                            Category = Categories["Bouquet of flowers"],
                            ImageUrl = "http://www.iflori.ro/image/cache/data/Buchete%20corporate/BC66%20Buchet%20flori%20crin%20alb%20pret%20%20235%20lei-500x500.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "http://www.iflori.ro/image/cache/data/Buchete%20corporate/BC66%20Buchet%20flori%20crin%20alb%20pret%20%20235%20lei-500x500.jpg"
                        },

                        new Flower {
                            Name = "Chrysanthemum",
                            Price = 18.95M,
                            ShortDescription = "A happy looking flower",
                            LongDescription = "gffddf",
                            Category = Categories["Single flower"],
                            ImageUrl = "https://www.robertorossi.ro/images/produse/crizantema-75-cm-galben-87017-1.jpg",
                            InStock = false,
                            ImageThumbnailUrl = "https://www.robertorossi.ro/images/produse/crizantema-75-cm-galben-87017-1.jpg"
                        }
                    );
                }

                context.SaveChanges();
            }
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Single flower" },
                        new Category { CategoryName = "Bouquet of flowers" },
                        new Category { CategoryName = "Seasonal flowers" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
