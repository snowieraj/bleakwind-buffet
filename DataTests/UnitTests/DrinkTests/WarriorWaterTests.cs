/*
 * Author: Andrew Yi 
 * Class: WarriorWaterTest.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using System;

using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater drinkOrder = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(drinkOrder);
        }
        [Fact]
        public void ShouldBeAssignableToIOrderItemDrinkClass()
        {
            
            WarriorWater test4 = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(test4);

        }
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater drinkOrder = new WarriorWater();
            Assert.True(drinkOrder.Ice);

        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater drinkOrder = new WarriorWater();
            Assert.Equal(Size.Small, drinkOrder.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda drinkOrder = new SailorSoda();
            drinkOrder.Ice = true;
            Assert.True(drinkOrder.Ice);
            drinkOrder.Ice = false;
            Assert.False(drinkOrder.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater drinkOrder = new WarriorWater();
            drinkOrder.Lemon = true;
            Assert.True(drinkOrder.Lemon);
            drinkOrder.Lemon = false;
            Assert.False(drinkOrder.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater drinkOrder = new WarriorWater();
            drinkOrder.Size = Size.Large;
            Assert.Equal(Size.Large, drinkOrder.Size);
            drinkOrder.Size = Size.Medium;
            Assert.Equal(Size.Medium, drinkOrder.Size);
            drinkOrder.Size = Size.Small;
            Assert.Equal(Size.Small, drinkOrder.Size);
        }


        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater drinkOrder = new WarriorWater();
            drinkOrder.Size = size;
            Assert.Equal(price, drinkOrder.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater drinkOrder = new WarriorWater();
            drinkOrder.Size = size;
            Assert.Equal(cal, drinkOrder.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater drinkOrder = new WarriorWater();
            drinkOrder.Ice = includeIce;
            drinkOrder.Lemon = includeLemon;
            if (!includeIce) Assert.Contains("Hold ice", drinkOrder.SpecialInstructions);
            else if (includeLemon) Assert.Contains("Add lemon", drinkOrder.SpecialInstructions);
            else Assert.Empty(drinkOrder.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldHaveCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater drinkOrder = new WarriorWater();
            drinkOrder.Size = size;
            Assert.Equal(name, drinkOrder.ToString());
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotificationForSize(Size size)
        {
            var item = new WarriorWater();
            if (size == Size.Small) item.Size = Size.Medium;
            Assert.PropertyChanged(item, "Size", () => item.Size = size);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotificationForPrice(Size size)
        {
            var item = new WarriorWater();
            if (size == Size.Small) item.Size = Size.Medium;
            Assert.PropertyChanged(item, "Price", () => item.Size = size);
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotificationForCalories(Size size)
        {
            var item = new WarriorWater();
            if (size == Size.Small) item.Size = Size.Medium;
            Assert.PropertyChanged(item, "Calories", () => item.Size = size);
        }

        [Fact]
        public void ChangingIceNotification()
        {
            var item = new WarriorWater();
            Assert.PropertyChanged(item, "Ice", () =>
            {
                item.Ice = false;
            });
            Assert.PropertyChanged(item, "Ice", () =>
            {
                item.Ice = true;
            });
        }

        [Fact]
        public void ChangingLemonNotification()
        {
            var item = new WarriorWater();
            Assert.PropertyChanged(item, "Lemon", () =>
            {
                item.Lemon = true;
            });
            Assert.PropertyChanged(item, "Lemon", () =>
            {
                item.Lemon = false;
            });
        }
    }
}
