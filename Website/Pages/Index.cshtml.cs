using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data.Menu;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        
        public IEnumerable<IOrderItem> OrderItems { get; protected set; }

        
        public string SearchTerms { get; set; }


        public List<IOrderItem> Entree { get; set; }

        public List<IOrderItem> Side { get; set; }

        public List<IOrderItem> Drink { get; set; }
        
        public int? CalorieMax { get; set; }

        public int? CalorieMin { get; set; }

        public double? PriceMin { get; set; }

        public double? PriceMax { get; set; }
 

        public void OnGet(string Searching, string[] MenuChoice, double? PriceMin, double? PriceMax, int? CalorieMin, int? CalorieMax)
        {
            SearchTerms = Searching;
            OrderItems = Menu.All;
            //OrderItems = Menu.Search(OrderItems, Searching);
            //OrderItems = Menu.FilterByCalories(OrderItems, CalorieMin, CalorieMax);
            //OrderItems = Menu.FilterByPrice(OrderItems, PriceMin, PriceMax);
            //OrderItems = Menu.FilterByChoice(OrderItems, MenuChoice);

            //Search for items in SearchTerms
            if (Searching != null)
            {
                string temp = Searching;
                string[] words = temp.Split(' ', StringSplitOptions.RemoveEmptyEntries);
               
                OrderItems = OrderItems.Where(item =>
                item.ToString() != null && item.ToString().Contains(Searching, StringComparison.CurrentCultureIgnoreCase) ||
                item.Description != null && item.Description.Contains(Searching, StringComparison.CurrentCultureIgnoreCase) ||
                item.Description != null && item.Description.Contains(words[0]) ||
                item.Description != null && words.Length == 2 && item.Description.Contains(words[1]) ||
                item.Description != null && words.Length == 3 && item.Description.Contains(words[1]) ||
                item.Description != null && words.Length == 3 && item.Description.Contains(words[2]));
              
            }

            //Filter by choice
            if (MenuChoice.Length != 0)
            {
                OrderItems = OrderItems.Where(item => 
                item is BleakwindBuffet.Data.Entrees.Entree && MenuChoice.Contains("Entree") ||
                item is BleakwindBuffet.Data.Sides.Side && MenuChoice.Contains("Side") ||
                item is BleakwindBuffet.Data.Drinks.Drink && MenuChoice.Contains("Drink"));
            }

            
            //Filter by Calories
            //Filter for Max Calories
            if (CalorieMin == null && CalorieMax != null)
            {
                OrderItems = OrderItems.Where(item => item.Calories <= CalorieMax);
            }
            //Filter for Min Calories
            if (CalorieMax == null && CalorieMin != null)
            {
                OrderItems = OrderItems.Where(item => item.Calories >= CalorieMin);
            }
            //Filter for Min and Max Calories
            if(CalorieMin != null && CalorieMax != null)
            {
                OrderItems = OrderItems.Where(item =>
                item.Calories >= CalorieMin && item.Calories <= CalorieMax);
            }
           
            
            //Filter by Price
            if (PriceMin == null && PriceMax != null)
            {
                OrderItems = OrderItems.Where(item =>
                item.Price <= PriceMax);
            }
            
            if (PriceMax == null && PriceMin != null)
            {
                OrderItems = OrderItems.Where(item =>
                item.Price >= PriceMin);
            }
            if (PriceMin != null && PriceMax != null)
            {
                OrderItems = OrderItems.Where(item =>
                item.Price >= PriceMin && item.Price <= PriceMax);
            }
            
            
            Entree = new List<IOrderItem>();
            Drink = new List<IOrderItem>();
            Side = new List<IOrderItem>();

            foreach (IOrderItem item in OrderItems)
            {
                if (item is BleakwindBuffet.Data.Entrees.Entree)
                {
                    Entree.Add(item);
                }
                if (item is BleakwindBuffet.Data.Sides.Side)
                {
                    Side.Add(item);
                }
                if (item is BleakwindBuffet.Data.Drinks.Drink)
                {
                    Drink.Add(item);
                }
            }
            

        }
    }
}
