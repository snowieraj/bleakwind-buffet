/*
 * Author: Zachery Brunner
 * Editor: Andrew Yi
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldBeAEntree()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(foodOrder);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemEntreeClass()
        {
          
            ThalmorTriple test5 = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(test5);
        
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            Assert.True(foodOrder.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            Assert.True(foodOrder.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            Assert.True(foodOrder.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            Assert.True(foodOrder.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            Assert.True(foodOrder.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            Assert.True(foodOrder.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            Assert.True(foodOrder.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            Assert.True(foodOrder.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            Assert.True(foodOrder.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            Assert.True(foodOrder.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            foodOrder.Bun = true;
            Assert.True(foodOrder.Bun);
            foodOrder.Bun = false;
            Assert.False(foodOrder.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            foodOrder.Ketchup = true;
            Assert.True(foodOrder.Ketchup);
            foodOrder.Ketchup = false;
            Assert.False(foodOrder.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            foodOrder.Mustard = true;
            Assert.True(foodOrder.Mustard);
            foodOrder.Mustard = false;
            Assert.False(foodOrder.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            foodOrder.Pickle = true;
            Assert.True(foodOrder.Pickle);
            foodOrder.Pickle = false;
            Assert.False(foodOrder.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            foodOrder.Cheese = true;
            Assert.True(foodOrder.Cheese);
            foodOrder.Cheese = false;
            Assert.False(foodOrder.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            foodOrder.Tomato = true;
            Assert.True(foodOrder.Tomato);
            foodOrder.Tomato = false;
            Assert.False(foodOrder.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            foodOrder.Lettuce = true;
            Assert.True(foodOrder.Lettuce);
            foodOrder.Lettuce = false;
            Assert.False(foodOrder.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            foodOrder.Mayo = true;
            Assert.True(foodOrder.Mayo);
            foodOrder.Mayo = false;
            Assert.False(foodOrder.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            foodOrder.Bacon = true;
            Assert.True(foodOrder.Bacon);
            foodOrder.Bacon = false;
            Assert.False(foodOrder.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            foodOrder.Egg = true;
            Assert.True(foodOrder.Egg);
            foodOrder.Egg = false;
            Assert.False(foodOrder.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            Assert.Equal(8.32, foodOrder.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            Assert.Equal((uint)943, foodOrder.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            foodOrder.Bun = includeBun;
            foodOrder.Ketchup = includeKetchup;
            foodOrder.Mustard = includeMustard;
            foodOrder.Pickle = includePickle;
            foodOrder.Cheese = includeCheese;
            foodOrder.Lettuce = includeLettuce;
            foodOrder.Mayo = includeMayo;
            foodOrder.Bacon = includeBacon;
            foodOrder.Egg = includeEgg;
            foodOrder.Tomato = includeTomato;

            if (!includeBun) Assert.Contains("Hold bun", foodOrder.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", foodOrder.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", foodOrder.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", foodOrder.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", foodOrder.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", foodOrder.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", foodOrder.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", foodOrder.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", foodOrder.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", foodOrder.SpecialInstructions);
            else Assert.Empty(foodOrder.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", foodOrder.ToString());
        }
        [Fact]
        public void ShouldReturnCorrectToStringName()
        {
            ThalmorTriple foodOrder = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", foodOrder.Name);
        }


        [Fact]
        public void ChangingBunNotification()
        {
            var item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Bun", () =>
            {
                item.Bun = false;
            });
            Assert.PropertyChanged(item, "Bun", () =>
            {
                item.Bun = true;
            });

        }

        [Fact]
        public void ChangingKetchupNotification()
        {
            var item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Ketchup", () =>
            {
                item.Ketchup = false;
            });
            Assert.PropertyChanged(item, "Ketchup", () =>
            {
                item.Ketchup = true;
            });
        }
        [Fact]
        public void ChangingMustardNotification()
        {
            var item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Mustard", () =>
            {
                item.Mustard = false;
            });
            Assert.PropertyChanged(item, "Mustard", () =>
            {
                item.Mustard = true;
            });
        }
        [Fact]
        public void ChangingPickleNotification()
        {
            var item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Pickle", () =>
            {
                item.Pickle = false;
            });
            Assert.PropertyChanged(item, "Pickle", () =>
            {
                item.Pickle = true;
            });
        }
        [Fact]
        public void ChangingCheeseNotification()
        {
            var item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Cheese", () =>
            {
                item.Cheese = false;
            });
            Assert.PropertyChanged(item, "Cheese", () =>
            {
                item.Cheese = true;
            });
        }

        [Fact]
        public void ChangingTomatoNotification()
        {
            var item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Tomato", () =>
            {
                item.Tomato = false;
            });
            Assert.PropertyChanged(item, "Tomato", () =>
            {
                item.Tomato = true;
            });
        }
        [Fact]
        public void ChangingLettuceNotification()
        {
            var item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Lettuce", () =>
            {
                item.Lettuce = false;
            });
            Assert.PropertyChanged(item, "Lettuce", () =>
            {
                item.Lettuce = true;
            });
        }
        [Fact]
        public void ChangingMayoNotification()
        {
            var item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Mayo", () =>
            {
                item.Mayo = false;
            });
            Assert.PropertyChanged(item, "Mayo", () =>
            {
                item.Mayo = true;
            });
        }

        [Fact]
        public void ChangingEggLinkNotification()
        {
            var item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Egg", () =>
            {
                item.Egg = false;
            });
            Assert.PropertyChanged(item, "Egg", () =>
            {
                item.Egg = true;
            });
        }

        [Fact]
        public void ChaningBaconNotification()
        {
            var item = new ThalmorTriple();
            Assert.PropertyChanged(item, "Bacon", () =>
            {
                item.Bacon = false;

            });
            Assert.PropertyChanged(item, "Bacon", () =>
            {
                item.Bacon = true;

            });
        }
    }
}