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
using System.Runtime.InteropServices.ComTypes;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
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
            SailorsSoda drinkOrder = new SailorsSoda();
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
    }
}
