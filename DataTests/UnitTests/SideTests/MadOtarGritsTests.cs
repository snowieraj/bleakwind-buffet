/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits foodOrder = new MadOtarGrits();
            Assert.Equal(Size.Small, foodOrder.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits foodOrder = new MadOtarGrits();
            foodOrder.Size = Size.Large;
            Assert.Equal(Size.Large, foodOrder.Size);
            foodOrder.Size = Size.Medium;
            Assert.Equal(Size.Medium, foodOrder.Size);
            foodOrder.Size = Size.Small;
            Assert.Equal(Size.Small, foodOrder.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits foodOrder = new MadOtarGrits();
            Assert.Empty(foodOrder.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits foodOrder = new MadOtarGrits();
            foodOrder.Size = size;
            Assert.Equal(price, foodOrder.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits foodOrder = new MadOtarGrits();
            foodOrder.Size = size;
            Assert.Equal(calories, foodOrder.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits foodOrder = new MadOtarGrits();
            foodOrder.Size = size;
            Assert.Equal(name, foodOrder.ToString());
        }
    }
}