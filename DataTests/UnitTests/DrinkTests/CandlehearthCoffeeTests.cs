/*
 * Author: Zachery Brunner
 * Editor: Andrew Yi
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.Reflection.Metadata;
using System.ComponentModel.Design;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee drinkOrder = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(drinkOrder);
        }
        [Fact]
        public void ShouldBeAssignableToIOrderItemDrinkClass()
        {

            CandlehearthCoffee test1 = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(test1);
        
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.Equal(Size.Small, chc.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Ice = true;
            Assert.True(chc.Ice);
            chc.Ice = false;
            Assert.False(chc.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Decaf = true;
            Assert.True(chc.Decaf);
            chc.Decaf = false;
            Assert.False(chc.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.RoomForCream = true;
            Assert.True(chc.RoomForCream);
            chc.RoomForCream = false;
            Assert.False(chc.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = Size.Large;
            Assert.Equal(Size.Large, chc.Size);
            chc.Size = Size.Medium;
            Assert.Equal(Size.Medium, chc.Size);
            chc.Size = Size.Small;
            Assert.Equal(Size.Small, chc.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = size;
            Assert.Equal(price, chc.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = size;
            Assert.Equal(cal, chc.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();

            chc.Ice = includeIce;
            chc.RoomForCream = includeCream;
            if (includeIce) Assert.Contains("Add ice", chc.SpecialInstructions);
            else if (includeCream) Assert.Contains("Add cream", chc.SpecialInstructions);
            else Assert.Empty(chc.SpecialInstructions);
            
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = size;
            chc.Decaf = decaf;
            Assert.Equal(name, chc.ToString());
        }
        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToNameasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = size;
            chc.Decaf = decaf;
            Assert.Equal(name, chc.Name);
        }

        [Fact]
        public void ChangingIceNotification()
        {
            var aj = new CandlehearthCoffee();
            Assert.PropertyChanged(aj, "Ice", () =>
            {
                aj.Ice = true;
            });
            Assert.PropertyChanged(aj, "Ice", () =>
            {
                aj.Ice = false;
            });
        }

        [Fact]
        public void ChangingDecafNotification()
        {
            var aj = new CandlehearthCoffee();
            Assert.PropertyChanged(aj, "Decaf", () =>
            {
                aj.Decaf = true;
            });
            Assert.PropertyChanged(aj, "Decaf", () =>
            {
                aj.Decaf = false;
            });
        }

        [Fact]
        public void ChangingRoomForCreamNotification()
        {
            var aj = new CandlehearthCoffee();
            Assert.PropertyChanged(aj, "RoomForCream", () =>
            {
                aj.RoomForCream = true;
            });
            Assert.PropertyChanged(aj, "RoomForCream", () =>
            {
                aj.RoomForCream = false;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotificationForSize(Size size)
        {
            var aj = new CandlehearthCoffee();
            if (size == Size.Small) aj.Size = Size.Medium;
            Assert.PropertyChanged(aj, "Size", () => aj.Size = size);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotificationForPrice(Size size)
        {
            var aj = new CandlehearthCoffee();
            if (size == Size.Small) aj.Size = Size.Medium;
            Assert.PropertyChanged(aj, "Price", () => aj.Size = size);
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotificationForCalories(Size size)
        {
            var aj = new CandlehearthCoffee();
            if (size == Size.Small) aj.Size = Size.Medium;
            Assert.PropertyChanged(aj, "Calories", () => aj.Size = size);
        }
    }
}
