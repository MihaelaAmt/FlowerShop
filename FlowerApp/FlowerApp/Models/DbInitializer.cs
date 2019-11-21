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
                            LongDescription = @"True lilies have long, narrow leaves growing along the length of the stem and large,
                                                flamboyant flowers that are either single or in clusters.
                                                They grow from scaly bulbs.
                                                Many of the species are highly fragrant and typically range in height from 30cm − 120cm,
                                                although some can be much taller.",
                            Category = Categories["Single flower"],
                            ImageUrl = "https://www.florariaaly.ro/image/cache/data/Flori%20la%20fir/Crin%20imperial-500x500_0.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "https://www.florariaaly.ro/image/cache/data/Flori%20la%20fir/Crin%20imperial-500x500_0.jpg",
                            IsFlowerPresentation = true
                        },
                        new Flower
                        {
                            Name = "Rose",
                            Price = 18.95M,
                            ShortDescription = "Roses is beautiful!",
                            LongDescription = @"If the red rose's exquisite beauty isn't reason enough to make it the ideal choice to express your love,
                                                its symbolism of magic and passion adds a message beyond words.",
                            Category = Categories["Single flower"],
                            ImageUrl = "http://www.buchetetrandafiri.ro/poze/flori/un-fir-de-trandafir-rosu-OBIdz.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "http://www.buchetetrandafiri.ro/poze/flori/un-fir-de-trandafir-rosu-OBIdz.jpg",
                            IsFlowerPresentation = false
                        },
                        new Flower
                        {
                            Name = "Daisy",
                            Price = 18.95M,
                            ShortDescription = "White daisy flower",
                            LongDescription = @"The perfect bouquet to brighten someon'es day!
                                                White and yellow dasies accented with buplerum, greens, and a lovely yellow bow. ",
                            Category = Categories["Single flower"],
                            ImageUrl = "https://i.pinimg.com/originals/17/a5/d1/17a5d17b2f30c1ad24b6fd182dc89c59.jpg",
                            InStock = true, ImageThumbnailUrl = "https://i.pinimg.com/originals/17/a5/d1/17a5d17b2f30c1ad24b6fd182dc89c59.jpg",
                            IsFlowerPresentation = false
                        },
                        new Flower
                        {
                            Name = "Bouquet of roses",
                            Price = 15.95M,
                            ShortDescription = "101 roses",
                            LongDescription = @"A huge bouquet of 101 red roses can only carry one message:
                                                You are my only love.
                                                The rose is the king of flowers when it comes to their association with beauty and feminine grace,
                                                passionate and eternal love, sincere devotion.
                                                Appreciated since ancient times, the rose has been found in the paintings of artists as well as the pages of writers,
                                                their romanticism being well known. The bouquet of red roses is a classical choice,
                                                full of charm, elegance and distinction, communicating clearly the feelings of the giver.
                                                When you wish to declare your love in a stylish way offer an impressive bouquet of red roses
                                                that will overwhelm the senses through the beauty of its petals and sweet scent.",
                            Category = Categories["Bouquet of flowers"],
                            ImageUrl = "https://florariadevis.ro/1493-large_default/buchet-trandafiri.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "https://florariadevis.ro/1493-large_default/buchet-trandafiri.jpg",
                            IsFlowerPresentation = true
                        },

                        new Flower {
                            Name = "Hyacinth",
                            Price = 13.95M,
                            ShortDescription = "Spring flower",
                            LongDescription = @"The delightful aroma of spring, in one bouquet: hyacinth and fresia notes, in a colorful spring bouquet. 
                                                Important: The flowers we use are always fresh. Thus, in some cases they may be in the form of buds.
                                                They will open within 24 hours if in the room are between 23 and 25 Celsius degrees.
                                                In this case you can enjoy the freshness even more!",
                            Category = Categories["Seasonal flowers"],
                            ImageUrl = "https://www.giftidea.ro/wp-content/uploads/2017/02/3-1.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "https://www.giftidea.ro/wp-content/uploads/2017/02/3-1.jpg",
                            IsFlowerPresentation = false
                        },

                        new Flower {
                            Name = "Tulip",
                            Price = 17.95M,
                            ShortDescription = "Spring flower",
                            LongDescription = @"Tulips are undoubtedly some of the most loved flowers.
                                                They have a long history, their origin being in the Himalayas.
                                                They were first brought to Europe by Turks in the sixteenth century,
                                                when they became the favorite flowers at the court of Ottoman Empire`s Sultan.
                                                The scientific name of the tulip , ""Tulipa"", means ""turban"" and relates to the shape of the flower.
                                                In any season the tulips remains one of the most appreciated flowers,
                                                so who would not enjoy a surprise which contain colourful tulips?
                                                Order online this wonderful bouquet and someone you love will be happy!",
                            Category = Categories["Seasonal flowers"],
                            ImageUrl = "https://floridebrasov.ro/pics/6/0.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "https://floridebrasov.ro/pics/6/0.jpg",
                            IsFlowerPresentation = false
                        },

                        new Flower {
                            Name = "Bouquet of field flowers",
                            Price = 15.95M,
                            ShortDescription = "Field flowers",
                            LongDescription = @"A summery mix of yellow daisy chrysanthemums,
                            purple asters and red and orange carnations - arranged
                            in a clear ginger vase and adorned with a cheerful green plaid bow - will make their wishes come true!",
                            Category = Categories["Bouquet of flowers"],
                            ImageUrl = "https://www.magnolia.ro/images/products/1562829074img_7543.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "https://www.magnolia.ro/images/products/1562829074img_7543.jpg",
                            IsFlowerPresentation = true
                        },

                        new Flower {
                            Name = "Pearl",
                            Price = 12.95M,
                            ShortDescription = "For lovers of spring",
                            LongDescription = @"Pearl flowers, are among the first flowers to appear in early spring.
                                                Their unmistakable fragrance soothes our senses.
                                                As beautiful and graceful as they are,
                                                they are fair and graceful.For this reason,
                                                their use in floral arrangements is less common.",
                            Category = Categories["Seasonal flowers"],
                            ImageUrl = "https://s12emagst.akamaized.net/products/3599/3598987/images/res_6664a230d1124f1cbe0eb246f0c7a477_full.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "https://s12emagst.akamaized.net/products/3599/3598987/images/res_6664a230d1124f1cbe0eb246f0c7a477_full.jpg",
                            IsFlowerPresentation = true
                        },

                        new Flower {
                            Name = "Peony bouquet",
                            Price = 15.95M,
                            ShortDescription = "King in the spring garden",
                            LongDescription = @"For a delicate lady, a delicate bouquet.
                                                The combination of pink peony flowers, scented freesias,
                                                Matthiola and Brunia is absolutely charming.
                                                The pastel colors and the perfume give  the bouquet a romantic look and it is suitable for a sensitive person.",
                            Category = Categories["Bouquet of flowers"],
                            ImageUrl = "https://s12emagst.akamaized.net/products/6085/6084226/images/res_b401ee11c47ba7fb3762c91794496f22_full.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "https://s12emagst.akamaized.net/products/6085/6084226/images/res_b401ee11c47ba7fb3762c91794496f22_full.jpg",
                            IsFlowerPresentation = false
                        },
                        new Flower {
                            Name = "Bouquet of lilies",
                            Price = 15.95M,
                            ShortDescription = "Strong flower",
                            LongDescription = @"Our Spring Lilies bouquet is shipped in bud form,
                                                as most lilies are. Here's why this is a good thing:
                                                watching these flowers open over the course of a few days is a gift in itself.
                                                Imagine your recipient's delight as each day their bouquet of lilies grows brighter and bigger,
                                                reminding them of your thoughtfulness for at least a week.",
                            Category = Categories["Bouquet of flowers"],
                            ImageUrl = "http://www.iflori.ro/image/cache/data/Buchete%20corporate/BC66%20Buchet%20flori%20crin%20alb%20pret%20%20235%20lei-500x500.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "http://www.iflori.ro/image/cache/data/Buchete%20corporate/BC66%20Buchet%20flori%20crin%20alb%20pret%20%20235%20lei-500x500.jpg",
                            IsFlowerPresentation = false
                        },

                        new Flower {
                            Name = "Chrysanthemum",
                            Price = 18.95M,
                            ShortDescription = "A happy looking flower",
                            LongDescription = @"A chrysanthemum is a beautiful flower,
                                                which is why you’ll see it on the Japanese royal crest today.
                                                You will find that there are about 30 different kinds of chrysanthemum out there today,
                                                so there are going to be a lot of different colors and styles.
                                                Today, the chrysanthemums that are out there are far more flash than the ones in the past.
                                                You will find that these flowers bloom often and they look great,
                                                they have a lot of little petals that provide a lot of volume and take up a lot of space which is why a lot of people like the look.
                                                They may come in a daisy like flower, a button flower, or even resembling a pom pom.
                                                You will find that you can get them in traditional colors like white and yellow,
                                                but they also come in reds and pinks today too.",
                            Category = Categories["Single flower"],
                            ImageUrl = "https://www.robertorossi.ro/images/produse/crizantema-75-cm-galben-87017-1.jpg",
                            InStock = true,
                            ImageThumbnailUrl = "https://www.robertorossi.ro/images/produse/crizantema-75-cm-galben-87017-1.jpg",
                            IsFlowerPresentation = false
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
