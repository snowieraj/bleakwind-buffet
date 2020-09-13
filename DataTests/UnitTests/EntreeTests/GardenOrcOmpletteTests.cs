/*
 * Author: Zachery Brunner
 * Editor: Andrew Yi
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAEntree()
        {
            GardenOrcOmelette foodOrder = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(foodOrder);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemEntreeClass()
        {
       
            GardenOrcOmelette test2 = new GardenOrcOmelette();
          Assert.IsAssignableFrom<IOrderItem>(test2);
       
        }
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette foodOrder = new GardenOrcOmelette();
            Assert.True(foodOrder.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette foodOrder = new GardenOrcOmelette();
            Assert.True(foodOrder.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette foodOrder = new GardenOrcOmelette();
            Assert.True(foodOrder.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette foodOrder = new GardenOrcOmelette();
            Assert.True(foodOrder.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette foodOrder = new GardenOrcOmelette();
            foodOrder.Broccoli = true;
            Assert.True(foodOrder.Broccoli);
            foodOrder.Broccoli = false;
            Assert.False(foodOrder.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette foodOrder = new GardenOrcOmelette();
            foodOrder.Mushrooms = true;
            Assert.True(foodOrder.Mushrooms);
            foodOrder.Mushrooms = false;
            Assert.False(foodOrder.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette foodOrder = new GardenOrcOmelette();
            foodOrder.Tomato = true;
            Assert.True(foodOrder.Tomato);
            foodOrder.Tomato = false;
            Assert.False(foodOrder.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette foodOrder = new GardenOrcOmelette();
            foodOrder.Cheddar = true;
            Assert.True(foodOrder.Cheddar);
            foodOrder.Cheddar = false;
            Assert.False(foodOrder.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette foodOrder = new GardenOrcOmelette();
            Assert.Equal(4.57, foodOrder.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette foodOrder = new GardenOrcOmelette();
            Assert.Equal((uint)404, foodOrder.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette foodOrder = new GardenOrcOmelette();
            foodOrder.Broccoli = includeBroccoli;
            foodOrder.Mushrooms = includeMushrooms;
            foodOrder.Tomato = includeTomato;
            foodOrder.Cheddar = includeCheddar;

            if (!includeBroccoli) Assert.Contains("Hold broccoli", foodOrder.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", foodOrder.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", foodOrder.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", foodOrder.SpecialInstructions);
            else Assert.Empty(foodOrder.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette foodOrder = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", foodOrder.ToString());
        }
    }
}