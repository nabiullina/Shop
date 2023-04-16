using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository {
    public class CategoryRepository: ICarsCategory {

        readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext appDBContext) {
            this.appDbContext = appDBContext;
        }
        public IEnumerable<Category> AllCategories => appDbContext.Category;
    }
}
