/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            MadOtarGrits foodOrder = new MadOtarGrits();
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
        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToNameBasedOnSize(Size size, string name)
        {
            MadOtarGrits foodOrder = new MadOtarGrits();
            foodOrder.Size = size;
            Assert.Equal(name, foodOrder.Name);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotificationForSize(Size size)
        {
            var aj = new MadOtarGrits();
            if (size == Size.Small) aj.Size = Size.Medium;
            Assert.PropertyChanged(aj, "Size", () => aj.Size = size);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotificationForPrice(Size size)
        {
            var aj = new MadOtarGrits();
            if (size == Size.Small) aj.Size = Size.Medium;
            Assert.PropertyChanged(aj, "Price", () => aj.Size = size);
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotificationForCalories(Size size)
        {
            var aj = new MadOtarGrits();
            if (size == Size.Small) aj.Size = Size.Medium;
            Assert.PropertyChanged(aj, "Calories", () => aj.Size = size);
        }
    }
}