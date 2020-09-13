/*
 * Author: Zachery Brunner
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            VokunSalad foodOrder = new VokunSalad();
            Assert.IsAssignableFrom<Side>(foodOrder);
        }
        [Fact]
        public void ShouldBeAssignableToIOrderItemSideClass()
        {
          
            VokunSalad test3 = new VokunSalad();
           Assert.IsAssignableFrom<IOrderItem>(test3);

        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad foodOrder = new VokunSalad();
            Assert.Equal(Size.Small, foodOrder.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad foodOrder = new VokunSalad();
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
            VokunSalad foodOrder = new VokunSalad();
            Assert.Empty(foodOrder.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad foodOrder = new VokunSalad();
            foodOrder.Size = size;
            Assert.Equal(price, foodOrder.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad foodOrder = new VokunSalad();
            foodOrder.Size = size;
            Assert.Equal(calories, foodOrder.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad foodOrder = new VokunSalad();
            foodOrder.Size = size;
            Assert.Equal(name, foodOrder.ToString());
        }
    }
}