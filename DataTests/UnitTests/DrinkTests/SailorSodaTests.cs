/*
 * Author: Zachery Brunner
 * Editor: Andrew Yi
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System.Runtime.InteropServices.ComTypes;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda drinkOrder = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(drinkOrder);
        }
        [Fact]
        public void ShouldBeAssignableToIOrderItemDrinkClass()
        {

            SailorSoda test3 = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(test3);


        }
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda drinkOrder = new SailorSoda();
            Assert.True(drinkOrder.Ice);
            
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda drinkOrder = new SailorSoda();
            Assert.Equal(Size.Small, drinkOrder.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda drinkOrder = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, drinkOrder.Flavor);
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
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda drinkOrder = new SailorSoda();
            drinkOrder.Size = Size.Large;
            Assert.Equal(Size.Large, drinkOrder.Size);
            drinkOrder.Size = Size.Medium;
            Assert.Equal(Size.Medium, drinkOrder.Size);
            drinkOrder.Size = Size.Small;
            Assert.Equal(Size.Small, drinkOrder.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda drinkOrder = new SailorSoda();
            drinkOrder.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, drinkOrder.Flavor);
            drinkOrder.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, drinkOrder.Flavor);
            drinkOrder.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, drinkOrder.Flavor);
            drinkOrder.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, drinkOrder.Flavor);
            drinkOrder.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, drinkOrder.Flavor);
            drinkOrder.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, drinkOrder.Flavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda drinkOrder = new SailorSoda();
            drinkOrder.Size = size;
            Assert.Equal(price, drinkOrder.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda drinkOrder = new SailorSoda();
            drinkOrder.Size = size;
            Assert.Equal(cal, drinkOrder.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda drinkOrder = new SailorSoda();
            drinkOrder.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", drinkOrder.SpecialInstructions);
            else Assert.Empty(drinkOrder.SpecialInstructions);
        }
        
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda drinkOrder = new SailorSoda();
            drinkOrder.Size = size;
            drinkOrder.Flavor = flavor;
            Assert.Equal(name, drinkOrder.ToString());
        }

        [Fact]
        public void ChangingIceNotification()
        {
            var item = new SailorSoda();
            Assert.PropertyChanged(item, "Ice", () =>
            {
                item.Ice = false;
            });
            Assert.PropertyChanged(item, "Ice", () =>
            {
                item.Ice = true;
            });
        }

        [Theory]
        [InlineData(SodaFlavor.Cherry)]
        [InlineData(SodaFlavor.Blackberry)]
        [InlineData(SodaFlavor.Grapefruit)]
        [InlineData(SodaFlavor.Lemon)]
        [InlineData(SodaFlavor.Peach)]
        [InlineData(SodaFlavor.Watermelon)]

        public void ChangingFlavorNotification(SodaFlavor flavor)
        {
            var item = new SailorSoda();
            if (flavor == SodaFlavor.Cherry) item.Flavor = SodaFlavor.Lemon;
            Assert.PropertyChanged(item, "Flavor", () => item.Flavor = flavor);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotificationForSize(Size size)
        {
            var item = new SailorSoda();
            if (size == Size.Small) item.Size = Size.Medium;
            Assert.PropertyChanged(item, "Size", () => item.Size = size);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotificationForPrice(Size size)
        {
            var item = new SailorSoda();
            if (size == Size.Small) item.Size = Size.Medium;
            Assert.PropertyChanged(item, "Price", () => item.Size = size);
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotificationForCalories(Size size)
        {
            var item = new SailorSoda();
            if (size == Size.Small) item.Size = Size.Medium;
            Assert.PropertyChanged(item, "Calories", () => item.Size = size);
        }
    }
}
