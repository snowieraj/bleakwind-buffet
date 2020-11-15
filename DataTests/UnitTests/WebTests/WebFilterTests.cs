using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Menu;
using Xunit;
namespace BleakwindBuffet.DataTests.UnitTests.WebTests
{
    public class WebFilterTests
    {
        [Fact]
        public void FilterByNothingShouldReturnFullMenu()
        {
            IEnumerable<IOrderItem> menu = Menu.All;

            IEnumerable<IOrderItem> results = Menu.Search(menu, null);
            List<IOrderItem> temp = results as List<IOrderItem>;
            Assert.Equal(52, temp.Count);

            results = Menu.FilterByChoice(menu, null);
            temp = results as List<IOrderItem>;
            Assert.Equal(52, temp.Count);

            results = Menu.FilterByCalories(menu, null, null);
            temp = results as List<IOrderItem>;
            Assert.Equal(52, temp.Count);

            results = Menu.FilterByPrice(menu, null, null);
            temp = results as List<IOrderItem>;
            Assert.Equal(52, temp.Count);

        }
        [Fact]
        public void FilterBySearchShouldReturnCorrectResult()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            IEnumerable<IOrderItem> results = Menu.Search(menu, "cherry");
            Assert.Collection(results,
                item => Assert.Contains("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Cherry Sailor Soda", item.ToString()));
            List<IOrderItem> temp = results as List<IOrderItem>;
            Assert.Equal(3, temp.Count);
        }
        [Fact]
        public void FilterByMenuChoiceShouldReturnCorrectResult()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            string[] choice = { "Entree" };
            IEnumerable<IOrderItem> results = Menu.FilterByChoice(menu, choice);
            Assert.Collection(results,
                item => Assert.Contains("Briarheart Burger", item.ToString()),
                item => Assert.Contains("Double Draugr", item.ToString()),
                item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                item => Assert.Contains("Philly Poacher", item.ToString()),
                item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                item => Assert.Contains("Thalmor Triple", item.ToString()),
                item => Assert.Contains("Thugs T-Bone", item.ToString()));
            List<IOrderItem> temp = (List<IOrderItem>)results;
            Assert.Equal(7, temp.Count);
        }
        [Fact]
        public void FilterByMinCalorieShouldReturnCorrectResults()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            IEnumerable<IOrderItem> results = Menu.FilterByCalories(menu, null, 0);
            Assert.Collection(results,
                item => Assert.Contains("Small Warrior Water", item.ToString()),
                item => Assert.Contains("Medium Warrior Water", item.ToString()),
                item => Assert.Contains("Large Warrior Water", item.ToString()));
            List<IOrderItem> temp = (List<IOrderItem>)results;
            Assert.Equal(3, temp.Count);
        }
        [Fact]
        public void FilterByMaxCalorieShouldReturnCorrectResults()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            IEnumerable<IOrderItem> results = Menu.FilterByCalories(menu, 930, null);
            Assert.Collection(results,
                item => Assert.Contains("Thalmor Triple", item.ToString()),
                item => Assert.Contains("Thugs T-Bone", item.ToString()));
            List<IOrderItem> temp = (List<IOrderItem>)results;
            Assert.Equal(2, temp.Count);
        }
        [Fact]
        public void FilterByCaloriesShouldReturnResults()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            IEnumerable<IOrderItem> results = Menu.FilterByCalories(menu, 0, 100);
            Assert.Collection(results,
                item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Large Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Small Vokun Salad", item.ToString()),
                item => Assert.Contains("Medium Vokun Salad", item.ToString()),
                item => Assert.Contains("Large Vokun Salad", item.ToString()),
                item => Assert.Contains("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Small Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Medium Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Large Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Small Markarth Milk", item.ToString()),
                item => Assert.Contains("Medium Markarth Milk", item.ToString()),
                item => Assert.Contains("Large Markarth Milk", item.ToString()),
                item => Assert.Contains("Small Warrior Water", item.ToString()),
                item => Assert.Contains("Medium Warrior Water", item.ToString()),
                item => Assert.Contains("Large Warrior Water", item.ToString()));
            List<IOrderItem> temp = (List<IOrderItem>)results;
            Assert.Equal(20, temp.Count);
        }

        [Fact]
        public void FilterByMinPriceShouldReturnCorrectResults()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            IEnumerable<IOrderItem> results = Menu.FilterByPrice(menu, null, 1);
            Assert.Collection(results,
                item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Large Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Small Vokun Salad", item.ToString()),
                item => Assert.Contains("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Small Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Small Warrior Water", item.ToString()),
                item => Assert.Contains("Medium Warrior Water", item.ToString()),
                item => Assert.Contains("Large Warrior Water", item.ToString()));

            List <IOrderItem> temp = (List<IOrderItem>)results;
            Assert.Equal(11, temp.Count);
        }
        [Fact]
        public void FilterByMaxPriceShouldReturnCorrectResults()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            IEnumerable<IOrderItem> results = Menu.FilterByPrice(menu, 8, null);
            Assert.Collection(results,
                item => Assert.Contains("Thalmor Triple", item.ToString()));
            List<IOrderItem> temp = (List<IOrderItem>)results;
            Assert.Single(temp);
        }
        [Fact]
        public void FilterByPriceShouldReturnCorrectResults()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            IEnumerable<IOrderItem> results = Menu.FilterByPrice(menu, 7, 8);
            Assert.Collection(results,
                item => Assert.Contains("Double Draugr", item.ToString()),
                item => Assert.Contains("Philly Poacher", item.ToString()));
            List<IOrderItem> temp = (List<IOrderItem>)results;
            Assert.Equal(2, temp.Count);
        }
        [Fact]
        public void ShouldReturnCorrectDescriptionsFromPriceFilter()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            IEnumerable<IOrderItem> results = Menu.FilterByPrice(menu, 7, 8);
            Assert.Collection(results,
                item => Assert.Contains("Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.", item.Description),
                item => Assert.Contains("Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.", item.Description));
            List<IOrderItem> temp = (List<IOrderItem>)results;
            Assert.Equal(2, temp.Count);
        }
        [Fact]
        public void ShouldReturnCorrectDescriptionsFromCalorieFilter()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            IEnumerable<IOrderItem> results = Menu.FilterByCalories(menu, 930, null);
            Assert.Collection(results,
                item => Assert.Contains("Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, " +
                "mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.", item.Description),
                item => Assert.Contains("Juicy T-Bone, not much else to say.", item.Description));
            List<IOrderItem> temp = (List<IOrderItem>)results;
            Assert.Equal(2, temp.Count);
        }
        [Fact]
        public void ShouldReturnCorrectDescriptionsFromSearch()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            IEnumerable<IOrderItem> results = Menu.Search(menu, "cherry");
            Assert.Collection(results,
                item => Assert.Contains("An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.", item.Description),
                item => Assert.Contains("An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.", item.Description),
                item => Assert.Contains("An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.", item.Description));
            List<IOrderItem> temp = (List<IOrderItem>)results;
            Assert.Equal(3, temp.Count);
        }
    }
}