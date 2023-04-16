using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data {
    public class DbObjects {
        public static void Inintial(AppDbContext content) {

            if (!content.Category.Any()) {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any()) {
                content.AddRange(
                    new Car {
                        Name = "Tesla",
                        ShortDesc = "",
                        LongDesc = "",
                        Img = "/img/tesla.jpg",
                        Price = 45000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Electocar"]
                    },
                    new Car {
                        Name = "Tesla",
                        ShortDesc = "",
                        LongDesc = "",
                        Img = "/img/tesla.jpg",
                        Price = 45000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Electocar"]
                    },
                    new Car {
                        Name = "Tesla",
                        ShortDesc = "",
                        LongDesc = "",
                        Img = "/img/tesla.jpg",
                        Price = 45000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Electocar"]
                    },
                    new Car {
                        Name = "Tesla",
                        ShortDesc = "",
                        LongDesc = "",
                        Img = "/img/tesla.jpg",
                        Price = 45000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Electocar"]
                    }
                );
            }
            content.SaveChanges();
        }
        static Dictionary<string, Category> category_;

        public static Dictionary<string, Category> Categories {
            get {
                if (category_ == null) {
                    var list = new Category[] {
                         new Category { CategoryName = "Electrocar", Desc = "Modern type of car" },
                        new Category { CategoryName = "Classic", Desc = "Cars with a classic engine" }
                    };
                    category_ = new Dictionary<string, Category>();
                    foreach (Category item in list)
                        category_.Add(item.CategoryName, item);
                }
                return category_;
            }
        }
    }
}
