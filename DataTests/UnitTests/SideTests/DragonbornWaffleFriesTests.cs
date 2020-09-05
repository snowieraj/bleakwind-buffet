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

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFriescs foodOrder = new DragonbornWaffleFriescs();
            Assert.Equal(Size.Small, foodOrder.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFriescs foodOrder = new DragonbornWaffleFriescs();
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
            DragonbornWaffleFriescs foodOrder = new DragonbornWaffleFriescs();
            Assert.Empty(foodOrder.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFriescs foodOrder = new DragonbornWaffleFriescs();
            foodOrder.Size = size;
            Assert.Equal(price, foodOrder.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFriescs foodOrder = new DragonbornWaffleFriescs();
            foodOrder.Size = size;
            Assert.Equal(calories, foodOrder.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFriescs foodOrder = new DragonbornWaffleFriescs();
            foodOrder.Size = size;
            Assert.Equal(name, foodOrder.ToString());
        }
    }
}