using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks {
    public class MockCars: IAllCars {
        readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars { get {
                return new List<Car> {
            new Car {Name = "Tesla", ShortDesc = "", LongDesc = "", 
                Img = "/img/tesla.jpg", Price = 45000, IsFavorite = true, 
                Available = true, Category=_carsCategory.AllCategories.First() },
            new Car {Name = "Tesla", ShortDesc = "", LongDesc = "", 
                Img = "/img/tesla.jpg", Price = 45000, IsFavorite = true,
                Available = true, Category=_carsCategory.AllCategories.First() },
            new Car {Name = "Tesla", ShortDesc = "", LongDesc = "", 
                Img = "/img/tesla.jpg", Price = 45000, IsFavorite = true, 
                Available = true, Category=_carsCategory.AllCategories.First() },
            new Car {Name = "Tesla", ShortDesc = "", LongDesc = "", 
                Img = "/img/tesla.jpg", Price = 45000, IsFavorite = true, 
                Available = true, Category=_carsCategory.AllCategories.First() }};
        }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetObjectCar(int carId) {
            throw new NotImplementedException();
        }
    }
}
