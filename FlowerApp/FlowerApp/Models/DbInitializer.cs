using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace FlowerApp.Models
{
    public static class DbInitializer
    {
        //create constant for Single flower
        private const string SingleFlower = "Single flower";
        //create constant for Bouquet of flowers
        private const string BouquetOfFlowers = "Bouquet of flowers";
        //create constant for Seasonal flowers
        private const string SeasonalFlowers = "Seasonal flowers";
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
                        //add a new flower
                        new Flower
                        {
                            //flower name
                            Name = "Lily",
                            //the price of the flower
                            Price = 12.95M,
                            //short description of the flower
                            ShortDescription = "Strong smell",
                            //long descriprion of the flower
                            LongDescription = @"True lilies have long, narrow leaves growing along the length of the stem and large,
                                                flamboyant flowers that are either single or in clusters.
                                                They grow from scaly bulbs.
                                                Many of the species are highly fragrant and typically range in height from 30cm − 120cm,
                                                although some can be much taller.",
                            //category of the flower
                            Category = Categories[SingleFlower],
                            //flower image
                            ImageUrl = "https://www.florariaaly.ro/image/cache/data/Flori%20la%20fir/Crin%20imperial-500x500_0.jpg",
                            //if in stock
                            InStock = true,
                            //image thumbnail
                            ImageThumbnailUrl = "" +
                            "https://www.florariaaly.ro/image/cache/data/Flori%20la%20fir/Crin%20imperial-500x500_0.jpg",
                            //if appears in flower presentation
                            IsFlowerPresentation = true
                        },
                        //another flower
                        new Flower
                        {
                            //flower name
                            Name = "Rose",
                            //the price of the flower
                            Price = 18.95M,
                            //short description of the flower
                            ShortDescription = "Roses is beautiful!",
                            //long description of the flowers
                            LongDescription = @"If the red rose's exquisite beauty isn't reason enough to make 
                                                it the ideal choice to express your love,
                                                its symbolism of magic and passion adds a message beyond words.",
                            //category of the flowers
                            Category = Categories[SingleFlower],
                            //flower image
                            ImageUrl = "http://www.buchetetrandafiri.ro/poze/flori/un-fir-de-trandafir-rosu-OBIdz.jpg",
                            //if in stock
                            InStock = true,
                            //image thumnail of the flower
                            ImageThumbnailUrl = "http://www.buchetetrandafiri.ro/poze/flori/un-fir-de-trandafir-rosu-OBIdz.jpg",
                            //if appears in flower presentation
                            IsFlowerPresentation = false
                        },
                        //add new flower
                        new Flower
                        {
                            //flower name
                            Name = "Daisy",
                            //the price of the flower
                            Price = 18.95M,
                            //short description of the flower
                            ShortDescription = "White daisy flower",
                            //long description of the flower
                            LongDescription = @"The perfect bouquet to brighten someon'es day!
                                                White and yellow dasies accented with buplerum, greens, and a lovely yellow bow. ",
                            //category of the flower
                            Category = Categories[SingleFlower],
                            //flower image
                            ImageUrl = "https://i.pinimg.com/originals/17/a5/d1/17a5d17b2f30c1ad24b6fd182dc89c59.jpg",
                            //if in stock
                            InStock = true,
                            //image thumbnail of the flower
                            ImageThumbnailUrl = "https://i.pinimg.com/originals/17/a5/d1/17a5d17b2f30c1ad24b6fd182dc89c59.jpg",
                            //if is in flower presentation
                            IsFlowerPresentation = false
                        },
                        //add a new flower
                        new Flower
                        {
                            //flower name
                            Name = "Bouquet of roses",
                            //the price of the flower 
                            Price = 15.95M,
                            //short description of the flower
                            ShortDescription = "101 roses",
                            //long description of the flower
                            LongDescription = @"A huge bouquet of 101 red roses can only carry one message:
                                                You are my only love.
                                                The rose is the king of flowers when it comes to 
                                                their association with beauty and feminine grace,
                                                passionate and eternal love, sincere devotion.
                                                Appreciated since ancient times, the rose has been found in the paintings 
                                                of artists as well as the pages of writers,
                                                their romanticism being well known. The bouquet of red roses is a classical choice,
                                                full of charm, elegance and distinction, communicating clearly the feelings of the giver.
                                                When you wish to declare your love in a stylish way offer an impressive bouquet of red roses
                                                that will overwhelm the senses through the beauty of its petals and sweet scent.",
                            //category of the flower
                            Category = Categories[BouquetOfFlowers],
                            //flower image
                            ImageUrl = "https://florariadevis.ro/1493-large_default/buchet-trandafiri.jpg",
                            //if in stock
                            InStock = true,
                            //image thumbnail of the flower
                            ImageThumbnailUrl = "https://florariadevis.ro/1493-large_default/buchet-trandafiri.jpg",
                            //if is in flower presentation
                            IsFlowerPresentation = true
                        },
                        //add a new flower
                        new Flower
                        {
                            //flower name
                            Name = "Hyacinth",
                            //the price of the flower
                            Price = 13.95M,
                            //short description of the flower
                            ShortDescription = "Spring flower",
                            //long description of the flower
                            LongDescription = @"The delightful aroma of spring, in one bouquet: 
                                                hyacinth and fresia notes, 
                                                in a colorful spring bouquet. 
                                                Important: The flowers we use are always fresh. Thus, 
                                                in some cases they may be in the form of buds.
                                                They will open within 24 hours if in the room are between 23 and 25 Celsius degrees.
                                                In this case you can enjoy the freshness even more!",
                            //category of the flower
                            Category = Categories[SeasonalFlowers],
                            //flower image
                            ImageUrl = "https://www.giftidea.ro/wp-content/uploads/2017/02/3-1.jpg",
                            //if in stock
                            InStock = true,
                            //image thumbnail of the flower
                            ImageThumbnailUrl = "https://www.giftidea.ro/wp-content/uploads/2017/02/3-1.jpg",
                            //if is in flower presentation
                            IsFlowerPresentation = false
                        },
                        //add a new flower
                        new Flower
                        {
                            //flower name
                            Name = "Tulip",
                            //the price of the flower
                            Price = 17.95M,
                            //short description of the flower
                            ShortDescription = "Spring flower",
                            //long description of the flower
                            LongDescription = @"Tulips are undoubtedly some of the most loved flowers.
                                                They have a long history, their origin being in the Himalayas.
                                                They were first brought to Europe by Turks in the sixteenth century,
                                                when they became the favorite flowers at the court of Ottoman Empire`s Sultan.
                                                The scientific name of the tulip , ""Tulipa"", means ""turban"" 
                                                and relates to the shape of the flower.
                                                In any season the tulips remains one of the most appreciated flowers,
                                                so who would not enjoy a surprise which contain colourful tulips?
                                                Order online this wonderful bouquet and someone you love will be happy!",
                            //category of the flower
                            Category = Categories[SeasonalFlowers],
                            //flower image
                            ImageUrl = "https://floridebrasov.ro/pics/6/0.jpg",
                            //if in stock
                            InStock = true,
                            //image thumbnail of the flower
                            ImageThumbnailUrl = "https://floridebrasov.ro/pics/6/0.jpg",
                            //if is in flower presentation
                            IsFlowerPresentation = false
                        },
                        //add new flower
                        new Flower
                        {
                            //flower name
                            Name = "Bouquet of field flowers",
                            //the price of the flower
                            Price = 15.95M,
                            //short description of the flower
                            ShortDescription = "Field flowers",
                            //long description of the flower
                            LongDescription = @"A summery mix of yellow daisy chrysanthemums,
                            purple asters and red and orange carnations - arranged
                            in a clear ginger vase and adorned with a cheerful green plaid bow - will make their wishes come true!",
                            //category of the flower
                            Category = Categories["Bouquet of flowers"],
                            //flower image
                            ImageUrl = "https://www.magnolia.ro/images/products/1562829074img_7543.jpg",
                            //if in stock
                            InStock = true,
                            //image thumbnail of the flower
                            ImageThumbnailUrl = "https://www.magnolia.ro/images/products/1562829074img_7543.jpg",
                            //if is in flower presentation
                            IsFlowerPresentation = true
                        },
                        //add new flower
                        new Flower
                        {
                            //flower name
                            Name = "Pearl",
                            //the price of the flower
                            Price = 12.95M,
                            //short description of the flower
                            ShortDescription = "For lovers of spring",
                            //long description of the flower
                            LongDescription = @"Pearl flowers, are among the first flowers to appear in early spring.
                                                Their unmistakable fragrance soothes our senses.
                                                As beautiful and graceful as they are,
                                                they are fair and graceful.For this reason,
                                                their use in floral arrangements is less common.",
                            //category of the flower
                            Category = Categories[SeasonalFlowers],
                            //flower image
                            ImageUrl =
                            "https://s12emagst.akamaized.net/products/3599/3598987/images/res_6664a230d1124f1cbe0eb246f0c7a477_full.jpg",
                            //if in stock
                            InStock = true,
                            //thumbnail image
                            ImageThumbnailUrl =
                            "https://s12emagst.akamaized.net/products/3599/3598987/images/res_6664a230d1124f1cbe0eb246f0c7a477_full.jpg",
                            //if in flower presentation
                            IsFlowerPresentation = true
                        },
                        //new flower
                        new Flower
                        {
                            //flower name
                            Name = "Peony bouquet",
                            //the price of the flower
                            Price = 15.95M,
                            //short description of the flower
                            ShortDescription = "King in the spring garden",
                            //long description of the flower
                            LongDescription = @"For a delicate lady, a delicate bouquet.
                                                The combination of pink peony flowers, scented freesias,
                                                Matthiola and Brunia is absolutely charming.
                                                The pastel colors and the perfume give  the bouquet a romantic 
                                                look and it is suitable for a sensitive person.",
                            //flower category
                            Category = Categories[BouquetOfFlowers],
                            //flower image
                            ImageUrl =
                            "https://s12emagst.akamaized.net/products/6085/6084226/images/res_b401ee11c47ba7fb3762c91794496f22_full.jpg",
                            //if in stock
                            InStock = true,
                            //image thumbnail
                            ImageThumbnailUrl =
                            "https://s12emagst.akamaized.net/products/6085/6084226/images/res_b401ee11c47ba7fb3762c91794496f22_full.jpg",
                            //if in flower presentation
                            IsFlowerPresentation = false
                        },
                        //add new flower
                        new Flower
                        {
                            //flower name
                            Name = "Bouquet of lilies",
                            //the price of flower
                            Price = 15.95M,
                            //short description of the flower
                            ShortDescription = "Strong flower",
                            //long description of the flower
                            LongDescription = @"Our Spring Lilies bouquet is shipped in bud form,
                                                as most lilies are. Here's why this is a good thing:
                                                watching these flowers open over the course of a few days is a gift in itself.
                                                Imagine your recipient's delight as each day their bouquet 
                                                of lilies grows brighter and bigger,
                                                reminding them of your thoughtfulness for at least a week.",
                            //flower category
                            Category = Categories[BouquetOfFlowers],
                            //flower image
                            ImageUrl =
                            "http://www.iflori.ro/image/cache/data/" +
                            "Buchete%20corporate/BC66%20Buchet%20flori%20crin%20alb%20pret%20%20235%20lei-500x500.jpg",
                            //if in stock
                            InStock = true,
                            //image thumbnail
                            ImageThumbnailUrl =
                            "http://www.iflori.ro/image/cache/data/" +
                            "Buchete%20corporate/BC66%20Buchet%20flori%20crin%20alb%20pret%20%20235%20lei-500x500.jpg",
                            //if in flower presentation
                            IsFlowerPresentation = false
                        },
                        //add new flower
                        new Flower
                        {
                            //flower name
                            Name = "Chrysanthemum",
                            //the price of the flower
                            Price = 18.95M,
                            //short description of the flower
                            ShortDescription = "A happy looking flower",
                            //long description of the flower
                            LongDescription = @"A chrysanthemum is a beautiful flower,
                                                which is why you’ll see it on the Japanese royal crest today.
                                                You will find that there are about 30 different kinds of chrysanthemum out there today,
                                                so there are going to be a lot of different colors and styles.
                                                Today, the chrysanthemums that are out there are far more flash than the ones in the past.
                                                You will find that these flowers bloom often and they look great,
                                                they have a lot of little petals that provide a lot of volume and
                                                take up a lot of space which is why a lot of people like the look.
                                                They may come in a daisy like flower, a button flower, or even resembling a pom pom.
                                                You will find that you can get them in traditional colors like white and yellow,
                                                but they also come in reds and pinks today too.",
                            //flower category
                            Category = Categories[SingleFlower],
                            //flower image
                            ImageUrl = "https://www.robertorossi.ro/images/produse/crizantema-75-cm-galben-87017-1.jpg",
                            //if in stock
                            InStock = true,
                            //image thumbnail
                            ImageThumbnailUrl = "https://www.robertorossi.ro/images/produse/crizantema-75-cm-galben-87017-1.jpg",
                            //if in flower presentation
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
                        //set categories
                        new Category { CategoryName = SingleFlower },
                        new Category { CategoryName = BouquetOfFlowers },
                        new Category { CategoryName = SeasonalFlowers }
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
