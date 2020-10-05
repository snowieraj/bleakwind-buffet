/*
 * Author: Zachery Brunner
 * Editor: Andrew Yi
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldBeAEntree()
        {
            PhillyPoacher foodOrder = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(foodOrder);
        }
       

        [Fact]
        public void ShouldBeAssignableToIOrderItemEntreeClass()
        {
           
            PhillyPoacher test3 = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(test3);
       
        } 
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

        [Fact]
        public void ChangingSirloinNotification()
        {
            var item = new PhillyPoacher();
            Assert.PropertyChanged(item, "Sirloin", () =>
            {
                item.Sirloin = false;
            });
            Assert.PropertyChanged(item, "Sirloin", () =>
            {
                item.Sirloin = true;
            });
        }

        [Fact]
        public void ChangingOnionNotification()
        {
            var item = new PhillyPoacher();
            Assert.PropertyChanged(item, "Onion", () =>
            {
                item.Onion = false;
            });
            Assert.PropertyChanged(item, "Onion", () =>
            {
                item.Onion = true;
            });
        }

        [Fact]
        public void ChangingRollNotification()
        {
            var item = new PhillyPoacher();
            Assert.PropertyChanged(item, "Roll", () =>
            {
                item.Roll = false;
            });
            Assert.PropertyChanged(item, "Roll", () =>
            {
                item.Roll = true;
            });
        }
    }
}