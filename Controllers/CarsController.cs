using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers {
    public class CarsController: Controller {
        readonly IAllCars _allCars;
        readonly ICarsCategory _carsCategory;

        public CarsController (IAllCars allCars, ICarsCategory carsCategory) {
            _allCars = allCars;
            _carsCategory = carsCategory;
        }

        public ViewResult List() {
            ViewBag.Title = "Страница с авто";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Auto";
            return View(obj);
        }
    }
}
