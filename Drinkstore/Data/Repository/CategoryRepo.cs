using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drinkstore.Data.Interfaces;
using Drinkstore.Models;

namespace Drinkstore.Data.Repository
{
    public class CategoryRepo : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>()
                {
                    new Category(){CategoryName = "Alcoholic", Description = "All alcoholic drinks here"},
                    new Category(){CategoryName = "Non-Alcoholic", Description = "All Non-alcoholic drinks here"}
                    
                };
            }
        }
    }
}
