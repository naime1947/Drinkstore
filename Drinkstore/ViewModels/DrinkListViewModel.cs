using Drinkstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinkstore.ViewModels
{
    public class DrinkListViewModel
    {
        public IEnumerable<Drink> Drinks { get; set; }
        public string CurrentCategory { get; set; }
    }
}
