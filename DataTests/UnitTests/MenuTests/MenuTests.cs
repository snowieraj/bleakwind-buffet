/*
 * Author: Andrew Yi
 * Class: Menu Test.cs
 * Purpose: Test the menu items
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.Threading.Channels;
using BleakwindBuffet.Data.Drinks;
using NuGet.Frameworks;

namespace BleakwindBuffet.DataTests.UnitTests.MenuTests
{
    public class MenuTests
    {
        [Fact]
        public void MenuReturnsAllEntrees()
        {
            Assert.Contains(Menu.Entrees(), (list) => { return list is BriarheartBurger; });
            Assert.Contains(Menu.Entrees(), (list) => { return list is DoubleDraugr; });
            Assert.Contains(Menu.Entrees(), (list) => { return list is GardenOrcOmelette; });
            Assert.Contains(Menu.Entrees(), (list) => { return list is PhillyPoacher; });
            Assert.Contains(Menu.Entrees(), (list) => { return list is SmokehouseSkeleton; });
            Assert.Contains(Menu.Entrees(), (list) => { return list is ThalmorTriple; });
            Assert.Contains(Menu.Entrees(), (list) => { return list is ThugsTBone; });
        }
        [Fact]
        public void MenuReturnsAllSides()
        {
            Assert.Contains(Menu.Sides(), (list) => { return list.ToString().Contains("Small Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.Sides(), (list) => { return list.ToString().Contains("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.Sides(), (list) => { return list.ToString().Contains("Large Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.Sides(), (list) => { return list.ToString().Contains("Small Fried Miraak"); });
            Assert.Contains(Menu.Sides(), (list) => { return list.ToString().Contains("Medium Fried Miraak"); });
            Assert.Contains(Menu.Sides(), (list) => { return list.ToString().Contains("Large Fried Miraak"); });
            Assert.Contains(Menu.Sides(), (list) => { return list.ToString().Contains("Small Mad Otar Grits"); });
            Assert.Contains(Menu.Sides(), (list) => { return list.ToString().Contains("Medium Mad Otar Grits"); });
            Assert.Contains(Menu.Sides(), (list) => { return list.ToString().Contains("Large Mad Otar Grits"); });
            Assert.Contains(Menu.Sides(), (list) => { return list.ToString().Contains("Small Vokun Salad"); });
            Assert.Contains(Menu.Sides(), (list) => { return list.ToString().Contains("Medium Vokun Salad"); });
            Assert.Contains(Menu.Sides(), (list) => { return list.ToString().Contains("Large Vokun Salad"); });
        }
        [Fact]
        public void MenuReturnsAllDrinks()
        {
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Small Aretino Apple Juice"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Medium Aretino Apple Juice"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Large Aretino Apple Juice"); });

            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Small Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Medium Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Large Candlehearth Coffee"); });

            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Small Decaf Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Medium Decaf Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Large Decaf Candlehearth Coffee"); });

            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Small Markarth Milk"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Medium Markarth Milk"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Large Markarth Milk"); });

            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Small Blackberry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Medium Blackberry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Large Blackberry Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Small Cherry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Medium Cherry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Large Cherry Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Small Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Medium Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Large Grapefruit Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Small Lemon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Medium Lemon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Large Lemon Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Small Peach Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Medium Peach Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Large Peach Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Small Watermelon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Medium Watermelon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Large Watermelon Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Small Warrior Water"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Medium Warrior Water"); });
            Assert.Contains(Menu.Drinks(), (list) => { return list.ToString().Contains("Large Warrior Water"); });


        }

     

        [Fact]
        public void MenuReturnsAll()
        {
           


            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Small Aretino Apple Juice"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Medium Aretino Apple Juice"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Large Aretino Apple Juice"); });

            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Small Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Medium Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Large Candlehearth Coffee"); });

            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Small Decaf Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Medium Decaf Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Large Decaf Candlehearth Coffee"); });

            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Small Markarth Milk"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Medium Markarth Milk"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Large Markarth Milk"); });

            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Small Blackberry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Medium Blackberry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Large Blackberry Sailor Soda"); });

            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Small Cherry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Medium Cherry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Large Cherry Sailor Soda"); });

            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Small Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Medium Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Large Grapefruit Sailor Soda"); });

            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Small Lemon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Medium Lemon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Large Lemon Sailor Soda"); });

            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Small Peach Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Medium Peach Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Large Peach Sailor Soda"); });

            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Small Watermelon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Medium Watermelon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Large Watermelon Sailor Soda"); });

            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Small Warrior Water"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Medium Warrior Water"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Large Warrior Water"); });

            Assert.Contains(Menu.FullMenu(), (list) => { return list is BriarheartBurger; });
            Assert.Contains(Menu.FullMenu(), (list) => { return list is DoubleDraugr; });
            Assert.Contains(Menu.FullMenu(), (list) => { return list is GardenOrcOmelette; });
            Assert.Contains(Menu.FullMenu(), (list) => { return list is PhillyPoacher; });
            Assert.Contains(Menu.FullMenu(), (list) => { return list is SmokehouseSkeleton; });
            Assert.Contains(Menu.FullMenu(), (list) => { return list is ThalmorTriple; });
            Assert.Contains(Menu.FullMenu(), (list) => { return list is ThugsTBone; });

            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Small Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Large Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Small Fried Miraak"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Medium Fried Miraak"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Large Fried Miraak"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Small Mad Otar Grits"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Medium Mad Otar Grits"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Large Mad Otar Grits"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Small Vokun Salad"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Medium Vokun Salad"); });
            Assert.Contains(Menu.FullMenu(), (list) => { return list.ToString().Contains("Large Vokun Salad"); });
        }

    }
}
