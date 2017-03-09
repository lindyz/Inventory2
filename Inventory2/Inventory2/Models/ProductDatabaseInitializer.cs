using System.Collections.Generic;
using System.Data.Entity;

namespace Inventory2.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Engine"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Body"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Interior"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Transmission"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Whole Truck"
                },
            };

            return categories;
        }

//seed data
        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Flywheel Housing for Cummins",
                    Description = "Drilled for straight up",
                    ImagePath="refer1.jpg",
                    UnitPrice = 150.00,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "1 7/8 Oil Filler Cap",
                    Description = "Fits a Cat, has chain",
                    ImagePath="refer1.jpg",
                    UnitPrice = 5.00,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "AC Condenser",
                    Description = "Fits a Mack",
                    ImagePath="refer1.jpg",
                    UnitPrice = 50.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "AC Condenser",
                    Description = "Fits a Kenworth",
                    ImagePath="refer1.jpg",
                    UnitPrice = 8.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Cat Turbo",
                    Description = "Fits CAT.",
                    ImagePath="refer1.jpg",
                    UnitPrice = 800.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Clearance Marker",
                    Description = "2 diode LED.",
                    ImagePath="refer1.jpg",
                    UnitPrice = 1.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Cab Light",
                    Description = "36 LED.",
                    ImagePath="refer1.jpg",
                    UnitPrice = 10.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Tail Light",
                    Description = "LED red with clear housing.",
                    ImagePath="refer1.jpg",
                    UnitPrice = 8.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Bezel",
                    Description = "Chrome",
                    ImagePath="refer1.jpg",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Sleeper Cab Light",
                    Description = "Three light, easy install",
                    ImagePath="refer1.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Fuel Oil Sender",
                    Description = "Sold individually",
                    ImagePath="refer1.jpg",
                    UnitPrice = 26.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Dash Light Lenses",
                    Description = "Assorted Colors",
                    ImagePath="refer1.jpg",
                    UnitPrice = 1.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Full Transmission",
                    Description = "Freightliner Columbia",
                    ImagePath="refer1.jpg",
                    UnitPrice = 1000.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Full Transmission",
                    Description = "Volvo Diesel",
                    ImagePath="refer1.jpg",
                    UnitPrice = 1000.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Full Transmission",
                    Description = "Freightliner Colimbia",
                    ImagePath="refer1.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "2005 Freightliner Columbia",
                    Description = "For parts or restoration",
                    ImagePath="refer1.jpg",
                    UnitPrice = 2500.00,
                    CategoryID = 5
                }
            };

            return products;
        }
    }
}