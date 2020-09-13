/*
 * Author: Zachery Brunner
 * Editor: Andrew Yi
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class IOrderItemTests
    {
        [Fact]
        public void ShouldBeAEntree()
        {
            ThugsTBone foodOrder = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(foodOrder);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemEntreeClass()
        {
          
            ThugsTBone test6 = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(test6);
        }
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone foodOrder = new ThugsTBone();
            Assert.Equal(6.44, foodOrder.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone foodOrder = new ThugsTBone();
            Assert.Equal((uint)982, foodOrder.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone foodOrder = new ThugsTBone();
            Assert.Empty(foodOrder.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone foodOrder = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", foodOrder.ToString());
        }
    }
}