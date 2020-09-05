﻿/*
 * Author: Zachery Brunner
 * Editor: Andrew Yi
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher foodOrder = new PhillyPoacher();
            Assert.True(foodOrder.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher foodOrder = new PhillyPoacher();
            Assert.True(foodOrder.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher foodOrder = new PhillyPoacher();
            Assert.True(foodOrder.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher foodOrder = new PhillyPoacher();
            foodOrder.Sirloin = true;
            Assert.True(foodOrder.Sirloin);
            foodOrder.Sirloin = false;
            Assert.False(foodOrder.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher foodOrder = new PhillyPoacher();
            foodOrder.Onion = true;
            Assert.True(foodOrder.Onion);
            foodOrder.Onion = false;
            Assert.False(foodOrder.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher foodOrder = new PhillyPoacher();
            foodOrder.Roll = true;
            Assert.True(foodOrder.Roll);
            foodOrder.Roll = false;
            Assert.False(foodOrder.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher foodOrder = new PhillyPoacher();
            Assert.Equal(7.23, foodOrder.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher foodOrder = new PhillyPoacher();
            Assert.Equal((uint)784, foodOrder.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher foodOrder = new PhillyPoacher();
            foodOrder.Sirloin = includeSirloin;
            foodOrder.Onion = includeOnion;
            foodOrder.Roll = includeRoll;


            if (!includeRoll) Assert.Contains("Hold roll", foodOrder.SpecialInstructions);
            if (!includeOnion) Assert.Contains("Hold onions", foodOrder.SpecialInstructions);
            if (!includeSirloin) Assert.Contains("Hold sirloin", foodOrder.SpecialInstructions);
            else Assert.Empty(foodOrder.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher foodOrder = new PhillyPoacher();
            Assert.Equal("Philly Poacher", foodOrder.ToString());
        }
    }
}