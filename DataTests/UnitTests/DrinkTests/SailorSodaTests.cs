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
using System.Runtime.InteropServices.ComTypes;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorsSoda drinkOrder = new SailorsSoda();
            Assert.True(drinkOrder.Ice);
            
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorsSoda drinkOrder = new SailorsSoda();
            Assert.Equal(Size.Small, drinkOrder.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorsSoda drinkOrder = new SailorsSoda();
            Assert.Equal(SodaFlavor.Cherry, drinkOrder.Soda);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorsSoda drinkOrder = new SailorsSoda();
            drinkOrder.Ice = true;
            Assert.True(drinkOrder.Ice);
            drinkOrder.Ice = false;
            Assert.False(drinkOrder.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorsSoda drinkOrder = new SailorsSoda();
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
            SailorsSoda drinkOrder = new SailorsSoda();
            drinkOrder.Soda = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, drinkOrder.Soda);
            drinkOrder.Soda = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, drinkOrder.Soda);
            drinkOrder.Soda = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, drinkOrder.Soda);
            drinkOrder.Soda = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, drinkOrder.Soda);
            drinkOrder.Soda = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, drinkOrder.Soda);
            drinkOrder.Soda = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, drinkOrder.Soda);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorsSoda drinkOrder = new SailorsSoda();
            drinkOrder.Size = size;
            Assert.Equal(price, drinkOrder.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorsSoda drinkOrder = new SailorsSoda();
            drinkOrder.Size = size;
            Assert.Equal(cal, drinkOrder.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorsSoda drinkOrder = new SailorsSoda();
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
            SailorsSoda drinkOrder = new SailorsSoda();
            drinkOrder.Size = size;
            drinkOrder.Soda = flavor;
            Assert.Equal(name, drinkOrder.ToString());
        }
    }
}
