using System;
using TileShop.Domain.Entities;

namespace TileShop.Infrastructure;

public static class DatabaseSeed
{
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
