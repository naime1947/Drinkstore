using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drinkstore.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Drinkstore.Controllers
{
    public class DrinkController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        private readonly ICategoryRepository _categoryRepository;

        public DrinkController(IDrinkRepository drinkRepository, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;
        }

        public ViewResult List()
        {
            var drinks = _drinkRepository.Drinks;
            return View(drinks);
        }
    }
}