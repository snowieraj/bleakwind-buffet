using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data.Menu;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        
        public IEnumerable<IOrderItem> OrderItems { get; protected set; }

        
        public string SearchTerms { get; set; }


        public List<IOrderItem> Entree { get; set; }

        public List<IOrderItem> Side { get; set; }

        public List<IOrderItem> Drink { get; set; }
        
        public IndexModel()
        {

        }

        public void OnGet(string Searching, IEnumerable<string> MenuChoice, double? PriceMin, double? PriceMax, int? CalorieMin, int? CalorieMax)
        {
            SearchTerms = Searching;
            OrderItems = Menu.FullMenu();
            OrderItems = Menu.Search(OrderItems, Searching);
            OrderItems = Menu.FilterByCalories(OrderItems, CalorieMin, CalorieMax);
            OrderItems = Menu.FilterByPrice(OrderItems, PriceMin, PriceMax);
            OrderItems = Menu.FilterByChoice(OrderItems, MenuChoice);
            

            Entree = new List<IOrderItem>();
            Drink = new List<IOrderItem>();
            Side = new List<IOrderItem>();
            
            foreach(IOrderItem item in OrderItems)
            {
                if(item is BleakwindBuffet.Data.Entrees.Entree)
                {
                    Entree.Add(item);
                }
                if (item is BleakwindBuffet.Data.Sides.Side)
                {
                    Side.Add(item);
                } 
                if(item is BleakwindBuffet.Data.Drinks.Drink)
                {
                    Drink.Add(item);
                }
            }
             
        }
    }
}
