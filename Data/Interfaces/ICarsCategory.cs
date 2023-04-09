using Shop.Data.Models; // подключение файлов из папки Models (наши классы)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces {
    public interface ICarsCategory {
        IEnumerable<Category> AllCategories { get; }
    }
}
