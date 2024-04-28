using Bogus;
using TileShop.Domain.Entities;

namespace TileShop.Infrastructure;

public static class DatabaseSeed
{
    public static List<string> Images = new()
    {
        "https://www.ikea.com/sa/en/images/products/ivar-side-unit__0653652_pe708072_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/besta-frame-grey-stained-walnut-effect__0315931_pe513552_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/hackas-handle-anthracite__0754253_pe747844_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/hackas-knob-anthracite__0754164_pe747806_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/eneryda-knob-black__0754160_pe747802_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/ivar-3-sections-shelves-pine__0106607_pe254883_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/eneryda-handle-black__0754248_pe747840_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/jonaxel-open-storage-combination-white__0773169_pe756209_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/jonaxel-2-legs-and-2-castors-white__0678066_pe719177_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/besta-drawer-runner-soft-closing__0626847_pe693027_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/besta-tv-bench-black-brown__0316215_pe516839_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/eket-wall-mounted-shelving-unit-white__1212327_pe910600_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/eket-wall-mounted-cabinet-combination-dark-grey__0478876_pe617896_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/eket-foot-adjustable-metal__0640666_pe699972_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/billy-oxberg-bookcase-with-glass-door-white-glass__0668171_pe714288_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/billsbro-handle-white__0754313_pe747894_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/vittsjoe-storage-combination-black-brown-glass__0754478_pe747936_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/bror-shelving-unit-black__0612497_pe688399_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/besta-burs-tv-bench-high-gloss-white__65138_pe175906_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/kolbjoern-shelving-unit-in-outdoor-beige__0664612_pe718449_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/kallax-insert-with-1-shelf-white__0627487_pe693406_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/jonaxel-storage-combination-white__0745781_pe743799_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/hejne-4-sections-shelves-softwood__0625798_pe692472_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/stuk-storage-case-white-grey__0711301_pe728139_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/kallax-shelving-unit-with-doors-black-brown__0645238_pe703345_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/eket-cabinet-with-4-compartments-dark-grey__0473428_pe614571_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/hemnes-bed-frame-with-2-storage-boxes-white-stain-luroey__1154508_pe886085_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/kura-reversible-bed-white-pine__0636268_pe697768_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/slaekt-underbed-with-storage-white__0637776_pe698534_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/ekedalen-ekedalen-bar-table-and-4-bar-stools-white-orrsta-light-grey__0747816_pe744734_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/nordviken-bar-stool-with-backrest-black__0714185_pe729959_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/yngvar-bar-stool-anthracite__0714270_pe729999_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/stensele-bar-table-anthracite-anthracite__0773220_pe756236_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/stensele-norraryd-bar-table-and-2-bar-stools-anthracite-anthracite-black__0680383_pe719836_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/ekedalen-bar-stool-with-backrest-dark-brown-orrsta-light-grey__0657901_pe710031_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/ekedalen-bar-stool-with-backrest-white-orrsta-light-grey__0657871_pe710003_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/ekedalen-bar-table-dark-brown__0657903_pe710032_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/raskog-bar-stool-black__0728072_pe736045_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/ekedalen-bar-table-white__0657888_pe710020_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/janinge-bar-stool-white__0728069_pe736042_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/tommaryd-table-anthracite__0740544_pe742053_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/ekedalen-ekedalen-bar-table-and-4-bar-stools-dark-brown-orrsta-light-grey__0747808_pe744732_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/franklin-bar-stool-with-backrest-foldable-black-black__0727485_pe735710_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/dalfred-bar-stool-black__0727486_pe735711_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/franklin-bar-stool-with-backrest-foldable-white-white__0727489_pe735714_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/ingolf-bar-stool-with-backrest-white__0728062_pe736035_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/norberg-wall-mounted-drop-leaf-table-white__0736622_pe740674_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/nordviken-nordviken-bar-table-and-4-bar-stools-black-black__0802746_pe768578_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/nordviken-bar-table-black__0714197_pe729961_s5.jpg?f=xl",
        "https://www.ikea.com/sa/en/images/products/norraryd-bar-stool-with-backrest-black__0728070_pe736043_s5.jpg?f=xl",
    };

    public static void AddCategories(ApplicationDbContext context)
    {
        var categoryFaker = new Faker<Category>()
            .RuleFor(c => c.Name, f => f.Commerce.ProductName());
        var categories = categoryFaker.Generate(15);
        context.Category.AddRange(categories);
        context.SaveChanges();
    }    

    public static async void AddProducts(ApplicationDbContext context)
    {
        var productFaker = new Faker<Product>()
            .RuleFor(p => p.Name, f => f.Commerce.ProductName())
            .RuleFor(p => p.Discount, f => f.Random.Number(0, 15))
            .RuleFor(p => p.AverageRating, f => f.Random.Number(0, 5))
            .RuleFor(p => p.CategoryId, f => f.Random.Number(1, 18))
            .RuleFor(p => p.ImageUrl, f => f.PickRandom(Images))
            .RuleFor(p => p.Price, f => f.Random.Number(1000, 25402));
        var products = productFaker.Generate(100);

        context.Product.AddRange(products);
        context.SaveChanges();

        var userFaker = new Faker<User>()
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(u => u.PasswordHash, f => "EcsZlEhb0tq+4U3afErNTP44ruxqK0j+D1g/gd0zlGw=")
            .RuleFor(u => u.PasswordSalt, f => "72998128-d8ad-4688-b06f-63d329330f71");

        var users = userFaker.Generate(100);
        context.User.AddRange(users);
        context.SaveChanges();

        var orderFaker = new Faker<Order>()
            .RuleFor(x => x.UserId, f => f.Random.Number(1, 100))
            .RuleFor(x => x.CreatedDate, f => f.Date.Past())
            .RuleFor(x => x.TotalPrice, f => f.Random.Number(1000, 250000));

        var orders = orderFaker.Generate(100);
        context.Order.AddRange(orders);
        context.SaveChanges();

        var orderDetailsFaker = new Faker<OrderDetails>()
            .RuleFor(x => x.ProductId, f => f.Random.Number(1, 100))
            .RuleFor(x => x.Quantity, f => f.Random.Number(1, 5))
            .RuleFor(x => x.OrderId, f => f.Random.Number(1, 100))
            .RuleFor(x => x.UnitPrice, f => f.Random.Number(1000, 20000));
        var orderDetails = orderDetailsFaker.Generate(150);
        context.OrderDetails.AddRange(orderDetails);
        context.SaveChanges();

        var reviewFaker = new Faker<Review>()
            .RuleFor(x => x.UserId, f => f.Random.Number(1, 20))
            .RuleFor(x => x.ProductId, f => f.Random.Number(1, 20))
            .RuleFor(x => x.Comment, f => f.Random.Words())
            .RuleFor(x => x.CreatedDate, f => f.Date.Past());
        var reviews = reviewFaker.Generate(50);
        context.Review.AddRange(reviews);
        context.SaveChanges();

        var featureFaker = new Faker<Feature>()
            .RuleFor(x => x.Name, f => f.Random.Word())
            .RuleFor(x => x.ProductId, f => f.Random.Number(1, 100));
        var features = featureFaker.Generate(200);
        context.Feature.AddRange(features);
        context.SaveChanges();

        var featureValueFaker = new Faker<FeatureValue>()
            .RuleFor(x => x.FeatureId, f => f.Random.Number(1, 200))
            .RuleFor(x => x.Value, f => f.Random.Word());
        var featureValues = featureValueFaker.Generate(400);
        context.FeatureValue.AddRange(featureValues);
        context.SaveChanges();
    }


    public static void SeedData(ApplicationDbContext context)
    {
        context.User.AddRange(new List<User>
        {
            new User
            {
                LastName = "Admin",
                FirstName = "Admin",
                Email = "admin@gmail.com",
                Role = UserRole.Admin,
                PasswordHash = "EcsZlEhb0tq+4U3afErNTP44ruxqK0j+D1g/gd0zlGw=",
                PasswordSalt = "72998128-d8ad-4688-b06f-63d329330f71",
                PhoneNumber = "11119999"
            },
            new User
            {
                LastName = "Owner",
                FirstName = "Owner",
                Email = "owner@gmail.com",
                Role = UserRole.Owner,
                PasswordHash = "EcsZlEhb0tq+4U3afErNTP44ruxqK0j+D1g/gd0zlGw=",
                PasswordSalt = "72998128-d8ad-4688-b06f-63d329330f71",
                PhoneNumber = "12345678"
            }
        });

        var testUser = context.User.Add(new User
        {
            LastName = "Test",
            FirstName = "Test",
            Email = "test@gmail.com",
            Role = UserRole.Client,
            PasswordHash = "EcsZlEhb0tq+4U3afErNTP44ruxqK0j+D1g/gd0zlGw=",
            PasswordSalt = "72998128-d8ad-4688-b06f-63d329330f71",
            PhoneNumber = "380994057538"
        });

        var shelfCategory = context.Category.Add(new Category { Name = "Шафи" });
        var bedCategory = context.Category.Add(new Category { Name = "Ліжка" });
        var tableCategory = context.Category.Add(new Category { Name = "Столи" });
        var chairCategory = context.Category.Add(new Category { Name = "Крісла" });
        context.SaveChanges();

        context.Basket.AddRange(new List<Basket>
        {
            new(){ UserId = 1 },
            new() { UserId = 2 },
            new() { UserId = 3 }
        });

        var shelf1 = context.Product.Add(new Product
        {
            Name = "Шафа розпашна",
            CategoryId = shelfCategory.Entity.Id,
            Price = 9780,
            Discount = 17
        });

        var shelf2 = context.Product.Add(new Product
        {
            Name = "Шафа купе",
            CategoryId = shelfCategory.Entity.Id,
            Price = 14690,
            Discount = 17
        });

        var shelf3 = context.Product.Add(new Product
        {
            Name = "Шафа купе \"Преміум\"",
            CategoryId = shelfCategory.Entity.Id,
            Price = 7970,
            Discount = 17
        });

        var shelf4 = context.Product.Add(new Product
        {
            Name = "Шафа К0006 \"Kuba\" Moreli",
            CategoryId = shelfCategory.Entity.Id,
            Price = 12195,
            Discount = 25
        });

        context.SaveChanges();

        var chair1 = context.Product.Add(new Product
        {
            Name = "Стілець ASTI 4A antr (BOX-2)",
            CategoryId = chairCategory.Entity.Id,
            Price = 2067,
            Discount = 0
        });

        var chair2 = context.Product.Add(new Product
        {
            Name = "Крісло ULTRA GTP Tilt PL64",
            CategoryId = chairCategory.Entity.Id,
            Price = 3444,
            Discount = 10
        });

        context.SaveChanges();

        context.Review.Add(new Review
        {
            ProductId = shelf1.Entity.Id,
            CreatedDate = DateTime.UtcNow,
            Comment = "Good shelf, very useful",
            UserId = testUser.Entity.Id
        });

        context.Rating.Add(new Rating
        {
            Score = 5,
            ProductId = shelf1.Entity.Id,
            UserId = testUser.Entity.Id
        });

        var widthFeature = context.Feature.Add(new Feature
        {
            Name = "Ширина",
            ProductId = shelf1.Entity.Id,
        });

        var heightFeature = context.Feature.Add(new Feature
        {
            Name = "Висота",
            ProductId = shelf1.Entity.Id
        });

        context.SaveChanges();

        context.FeatureValue.Add(new FeatureValue
        {
            FeatureId = widthFeature.Entity.Id,
            Value = "500"
        });

        context.FeatureValue.Add(new FeatureValue
        {
            FeatureId = heightFeature.Entity.Id,
            Value = "1200"
        });
        context.SaveChanges();
    }

    public static void SeedProductsFromCsv(ApplicationDbContext context, string filePath)
    {
        var products = new List<Product>();
        var imageLenght = Images.Count;
        int index = 0;
        try
        {
            using(var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if(parts.Length >= 5)
                    {
                        if (int.TryParse(parts[1], out int categoryId)
                            && double.TryParse(parts[2], out double discount)
                            && decimal.TryParse(parts[3], out decimal price)
                            && double.TryParse(parts[4], out double averageRating))
                        {
                            var product = new Product
                            {
                                Name = parts[0],
                                CategoryId = categoryId,
                                Discount = discount,
                                ImageUrl = Images[index],
                                Price = price,
                                AverageRating = averageRating
                            };
                            products.Add(product);
                            index += 1;
                            index %= imageLenght;
                        }
                    }
                }
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error reading file:{ex.Message}");
        }

        context.Product.AddRange(products);
        context.SaveChanges();
    }

    public static void SeedCategoriesFromCsv(ApplicationDbContext context, string filePath)
    {
        var categories = new List<Category>();

        try
        {
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        var category = new Category
                        {
                            Name = line
                        };
                        categories.Add(category);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file:{ex.Message}");
        }

        context.Category.AddRange(categories);
        context.SaveChanges();
    }

    public static void SeedUsersFromCsv(ApplicationDbContext context, string filePath)
    {
        var users = new List<User>();
        var baskets = new List<Basket>();

        try
        {
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 5)
                    {
                        if (int.TryParse(parts[0], out int id))
                        {
                            var user = new User
                            {
                                Id = id,
                                FirstName = parts[1],
                                LastName = parts[2],
                                Email = parts[3],
                                PhoneNumber = parts[4],
                                PasswordHash = "EcsZlEhb0tq+4U3afErNTP44ruxqK0j+D1g/gd0zlGw=",
                                PasswordSalt = "72998128-d8ad-4688-b06f-63d329330f71"
                            };
                            var basket = new Basket
                            {
                                UserId = id
                            };
                            users.Add(user);
                            baskets.Add(basket);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file:{ex.Message}");
        }

        context.User.AddRange(users);
        context.SaveChanges();

        context.Basket.AddRange(baskets);
        context.SaveChanges();
    }

    public static void SeedOrdersFromCsv(ApplicationDbContext context, string filePath)
    {
        var orders = new List<Order>();

        try
        {
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 3)
                    {
                        if (int.TryParse(parts[0], out int userId)
                            && DateTime.TryParse(parts[1], out DateTime date)
                            && decimal.TryParse(parts[2], out decimal totalPrice))
                        {
                            var order = new Order
                            {
                                CreatedDate = date,
                                UserId = userId,
                                TotalPrice = totalPrice
                            };
                            orders.Add(order);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file:{ex.Message}");
        }

        context.Order.AddRange(orders);
        context.SaveChanges();
    }

    public static void SeedOrderDetailsFromCsv(ApplicationDbContext context, string filePath)
    {
        var details = new List<OrderDetails>();

        try
        {
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 4)
                    {
                        if (int.TryParse(parts[0], out int orderId)
                            && int.TryParse(parts[1], out int productId)
                            && int.TryParse(parts[2], out int quantity)
                            && decimal.TryParse(parts[3], out decimal unitPrice))
                        {
                            var detail = new OrderDetails
                            {
                                OrderId = orderId,
                                ProductId = productId,
                                Quantity = quantity,
                                UnitPrice = unitPrice
                            };
                            details.Add(detail);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file:{ex.Message}");
        }

        context.OrderDetails.AddRange(details);
        context.SaveChanges();
    }

    public static void SeedRatingFromCsv(ApplicationDbContext context, string filePath)
    {
        var ratings = new List<Rating>();

        try
        {
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 3)
                    {
                        if (int.TryParse(parts[0], out int userId)
                            && int.TryParse(parts[1], out int productId)
                            && double.TryParse(parts[2], out double score))
                        {
                            var rating = new Rating
                            {
                                UserId = userId,
                                ProductId = productId,
                                Score = score
                            };
                            ratings.Add(rating);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file:{ex.Message}");
        }

        context.Rating.AddRange(ratings);
        context.SaveChanges();
    }

    public static void SeedReviewFromCsv(ApplicationDbContext context, string filePath)
    {
        var reviews = new List<Review>();

        try
        {
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 4)
                    {
                        if (int.TryParse(parts[0], out int userId)
                            && int.TryParse(parts[1], out int productId)
                            && DateTime.TryParse(parts[2], out DateTime date))
                        {
                            var review = new Review
                            {
                                ProductId = productId,
                                CreatedDate = date,
                                UserId = userId,
                                Comment = parts[3]
                            };
                            reviews.Add(review);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file:{ex.Message}");
        }

        context.Review.AddRange(reviews);
        context.SaveChanges();
    }

    public static void SeedFeaturesFromCsv(ApplicationDbContext context, string filePath)
    {
        var features = new List<Feature>();

        try
        {
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 2)
                    {
                        if (int.TryParse(parts[1], out int productId))
                        {
                            var feature = new Feature
                            {
                                Name = parts[0],
                                ProductId = productId
                            };
                            features.Add(feature);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file:{ex.Message}");
        }

        context.Feature.AddRange(features);
        context.SaveChanges();
    }

    public static void SeedFeatureValuesFromCsv(ApplicationDbContext context, string filePath)
    {
        var featureValues = new List<FeatureValue>();

        try
        {
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 4)
                    {
                        if (int.TryParse(parts[0], out int featureId))
                        {
                            var review = new FeatureValue
                            {
                                FeatureId = featureId,
                                Value = parts[1]
                            };
                            featureValues.Add(review);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file:{ex.Message}");
        }

        context.FeatureValue.AddRange(featureValues);
        context.SaveChanges();
    }
}
