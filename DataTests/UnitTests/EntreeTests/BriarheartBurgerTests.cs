/*
 * Author: Zachery Brunner
 * Editor: Andrew Yi
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.Net.Http;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ShouldBeAEntree()
        {
            BriarheartBurger foodOrder = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(foodOrder);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemEntreeClass()
        {
            BriarheartBurger test0 = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(test0);
  
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger foodOrder = new BriarheartBurger();
            Assert.True(foodOrder.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger foodOrder = new BriarheartBurger();
            Assert.True(foodOrder.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger foodOrder = new BriarheartBurger();
            Assert.True(foodOrder.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger foodOrder = new BriarheartBurger();
            Assert.True(foodOrder.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger foodOrder = new BriarheartBurger();
            Assert.True(foodOrder.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger foodOrder = new BriarheartBurger
            {
                Bun = true
            };
            Assert.True(foodOrder.Bun);
            foodOrder.Bun = false;
            Assert.False(foodOrder.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger foodOrder = new BriarheartBurger
            {
                Ketchup = true
            };
            Assert.True(foodOrder.Ketchup);
            foodOrder.Ketchup = false;
            Assert.False(foodOrder.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger foodOrder = new BriarheartBurger
            {
                Mustard = true
            };
            Assert.True(foodOrder.Mustard);
            foodOrder.Mustard = false;
            Assert.False(foodOrder.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger foodOrder = new BriarheartBurger();
            foodOrder.Pickle = true;
            Assert.True(foodOrder.Pickle);
            foodOrder.Pickle = false;
            Assert.False(foodOrder.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger foodOrder = new BriarheartBurger();
            foodOrder.Cheese = true;
            Assert.True(foodOrder.Cheese);
            foodOrder.Cheese = false;
            Assert.False(foodOrder.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger foodOrder = new BriarheartBurger();
            Assert.Equal(6.32, foodOrder.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger foodOrder = new BriarheartBurger();
            Assert.Equal((uint)743, foodOrder.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger foodOrder = new BriarheartBurger();
            foodOrder.Bun = includeBun;
            foodOrder.Ketchup = includeKetchup;
            foodOrder.Mustard = includeMustard;
            foodOrder.Pickle = includePickle;
            foodOrder.Cheese = includeCheese;

            if (!includeBun) Assert.Contains("Hold bun", foodOrder.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", foodOrder.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", foodOrder.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", foodOrder.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", foodOrder.SpecialInstructions);
            else Assert.Empty(foodOrder.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger foodOrder = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", foodOrder.ToString());
        }

        [Fact]
        public void ShouldReturnCorrectToStringName()
        {
            BriarheartBurger foodOrder = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", foodOrder.Name);
        }

        [Fact]
        public void ChangingBunNotification()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Bun", () =>
            {
                bb.Bun = false;
            });
            Assert.PropertyChanged(bb, "Bun", () =>
            {
                bb.Bun = true;
            });

        }

        [Fact]
        public void ChangingKetchupNotification()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Ketchup", () =>
            {
                bb.Ketchup = false;
            });
            Assert.PropertyChanged(bb, "Ketchup", () =>
            {
                bb.Ketchup = true;
            });
        }
        [Fact]
        public void ChangingMustardNotification()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Mustard", () =>
            {
                bb.Mustard = false;
            });
            Assert.PropertyChanged(bb, "Mustard", () =>
            {
                bb.Mustard = true;
            });
        }
        [Fact]
        public void ChangingPickleNotification()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Pickle", () =>
            {
                bb.Pickle = false;
            });
            Assert.PropertyChanged(bb, "Pickle", () =>
            {
                bb.Pickle = true;
            });
        }
        [Fact]
        public void ChangingCheeseNotification()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Cheese", () =>
            {
                bb.Cheese = false;
            });
            Assert.PropertyChanged(bb, "Cheese", () =>
            {
                bb.Cheese = true;
            });
        }


    }
}