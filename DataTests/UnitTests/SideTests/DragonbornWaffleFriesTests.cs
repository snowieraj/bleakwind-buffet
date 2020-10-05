/*
 * Author: Zachery Brunner
 * Editor: Andrew Yi
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries foodOrder = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(foodOrder);
        }
   
        [Fact]
        public void ShouldBeAssignableToIOrderItemSideClass()
        {
            DragonbornWaffleFries test0 = new DragonbornWaffleFries();
           Assert.IsAssignableFrom<IOrderItem>(test0);


        }    
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries foodOrder = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, foodOrder.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries foodOrder = new DragonbornWaffleFries();
            foodOrder.Size = Size.Large;
            Assert.Equal(Size.Large, foodOrder.Size);
            foodOrder.Size = Size.Medium;
            Assert.Equal(Size.Medium, foodOrder.Size);
            foodOrder.Size = Size.Small;
            Assert.Equal(Size.Small, foodOrder.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries foodOrder = new DragonbornWaffleFries();
            Assert.Empty(foodOrder.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries foodOrder = new DragonbornWaffleFries();
            foodOrder.Size = size;
            Assert.Equal(price, foodOrder.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries foodOrder = new DragonbornWaffleFries();
            foodOrder.Size = size;
            Assert.Equal(calories, foodOrder.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries foodOrder = new DragonbornWaffleFries();
            foodOrder.Size = size;
            Assert.Equal(name, foodOrder.ToString());
        }


        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotificationForSize(Size size)
        {
            var aj = new DragonbornWaffleFries();
            if (size == Size.Small) aj.Size = Size.Medium;
            Assert.PropertyChanged(aj, "Size", () => aj.Size = size);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotificationForPrice(Size size)
        {
            var aj = new DragonbornWaffleFries();
            if (size == Size.Small) aj.Size = Size.Medium;
            Assert.PropertyChanged(aj, "Price", () => aj.Size = size);
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotificationForCalories(Size size)
        {
            var aj = new DragonbornWaffleFries();
            if (size == Size.Small) aj.Size = Size.Medium;
            Assert.PropertyChanged(aj, "Calories", () => aj.Size = size);
        }
    }
}