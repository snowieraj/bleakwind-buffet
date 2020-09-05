/*
 * Author: Zachery Brunner
 * Editor: Andrew Yi
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {   
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            Assert.True(foodOrder.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            Assert.True(foodOrder.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            Assert.True(foodOrder.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            Assert.True(foodOrder.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            Assert.True(foodOrder.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            Assert.True(foodOrder.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            Assert.True(foodOrder.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            Assert.True(foodOrder.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            foodOrder.Bun = true;
            Assert.True(foodOrder.Bun);
            foodOrder.Bun = false;
            Assert.False(foodOrder.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            foodOrder.Ketchup = true;
            Assert.True(foodOrder.Ketchup);
            foodOrder.Ketchup = false;
            Assert.False(foodOrder.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            foodOrder.Mustard = true;
            Assert.True(foodOrder.Mustard);
            foodOrder.Mustard = false;
            Assert.False(foodOrder.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            foodOrder.Pickle = true;
            Assert.True(foodOrder.Pickle);
            foodOrder.Pickle = false;
            Assert.False(foodOrder.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            foodOrder.Cheese = true;
            Assert.True(foodOrder.Cheese);
            foodOrder.Cheese = false;
            Assert.False(foodOrder.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            foodOrder.Tomato = true;
            Assert.True(foodOrder.Tomato);
            foodOrder.Tomato = false;
            Assert.False(foodOrder.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            foodOrder.Lettuce = true;
            Assert.True(foodOrder.Lettuce);
            foodOrder.Lettuce = false;
            Assert.False(foodOrder.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            foodOrder.Mayo = true;
            Assert.True(foodOrder.Mayo);
            foodOrder.Mayo = false;
            Assert.False(foodOrder.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            Assert.Equal(7.32, foodOrder.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            Assert.Equal((uint)843, foodOrder.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            foodOrder.Bun = includeBun;
            foodOrder.Ketchup = includeKetchup;
            foodOrder.Mustard = includeMustard;
            foodOrder.Pickle = includePickle;
            foodOrder.Cheese = includeCheese;
            foodOrder.Lettuce = includeLettuce;
            foodOrder.Mayo = includeMayo;

            if (!includeBun) Assert.Contains("Hold bun", foodOrder.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", foodOrder.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", foodOrder.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", foodOrder.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", foodOrder.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", foodOrder.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", foodOrder.SpecialInstructions);
            else Assert.Empty(foodOrder.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr foodOrder = new DoubleDraugr();
            Assert.Equal("Double Draugr", foodOrder.ToString());
        }
    }
}