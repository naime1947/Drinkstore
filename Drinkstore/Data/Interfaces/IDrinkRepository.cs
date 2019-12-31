using Drinkstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinkstore.Data.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; set; }
        IEnumerable<Drink> PreferedDrinks { get; set; }
        Drink GetDrinkById(int drinkId);
    }
}
