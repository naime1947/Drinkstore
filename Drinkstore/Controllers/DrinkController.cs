using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drinkstore.Data.Interfaces;
using Drinkstore.ViewModels;
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
            var vm = new DrinkListViewModel();
            vm.Drinks = drinks;
            vm.CurrentCategory = "Alcohol category";
            return View(vm);
        }
    }
}