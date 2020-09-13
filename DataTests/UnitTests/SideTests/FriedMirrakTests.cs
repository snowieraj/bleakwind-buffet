/*
 * Author: Zachery Brunner
 * Editor: Andrew Yi
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            FriedMiraak foodOrder = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(foodOrder);
        }
        [Fact]
        public void ShouldBeAssignableToIOrderItemSideClass()
        {
            FriedMiraak test1 = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(test1);
       

        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak drinkOrder = new FriedMiraak();
            Assert.Equal(Size.Small, drinkOrder.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak drinkOrder = new FriedMiraak();
            drinkOrder.Size = Size.Large;
            Assert.Equal(Size.Large, drinkOrder.Size);
            drinkOrder.Size = Size.Medium;
            Assert.Equal(Size.Medium, drinkOrder.Size);
            drinkOrder.Size = Size.Small;
            Assert.Equal(Size.Small, drinkOrder.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak foodOrder = new FriedMiraak();
            Assert.Empty(foodOrder.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak drinkOrder = new FriedMiraak();
            drinkOrder.Size = size;
            Assert.Equal(price, drinkOrder.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak drinkOrder = new FriedMiraak();
            drinkOrder.Size = size;
            Assert.Equal(calories, drinkOrder.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak drinkOrder = new FriedMiraak();
            drinkOrder.Size = size;
            Assert.Equal(name, drinkOrder.ToString());
        }
    }
}