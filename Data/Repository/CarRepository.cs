﻿using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository {
    public class CarRepository: IAllCars {
        readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent) {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> GetFavCars => appDBContent.Car.Where(p => p.IsFavorite).Include(c=>c.Category);

        public Car GetObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.Id == carId);

        
    }
}
