using Bogus;
using TileShop.Domain.Entities;

namespace TileShop.Infrastructure;

public static class DatabaseSeed
{
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
            .RuleFor(p => p.ImageUrl, f => f.Image.LoremPixelUrl())
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
            .RuleFor(x => x.CreatedDate, f => f.Date.Past());

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
            .RuleFor(x => x.Comment, f => f.Lorem.Text())
            .RuleFor(x => x.CreatedDate, f => f.Date.Past());
        var reviews = reviewFaker.Generate(50);
        context.Review.AddRange(reviews);
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
}
