/*
 * Author: Zachery Brunner
 * Editor: Andrew Yi
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {        
        [Fact]
        public void ShouldBeAEntree()
        {
            SmokehouseSkeleton foodOrder = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(foodOrder);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemEntreeClass()
        {
          
            SmokehouseSkeleton test4 = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(test4);
        
        }
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton foodOrder = new SmokehouseSkeleton();
            Assert.True(foodOrder.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton foodOrder = new SmokehouseSkeleton();
            Assert.True(foodOrder.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton foodOrder = new SmokehouseSkeleton();
            Assert.True(foodOrder.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton foodOrder = new SmokehouseSkeleton();
            Assert.True(foodOrder.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton foodOrder = new SmokehouseSkeleton();
            foodOrder.SausageLink = true;
            Assert.True(foodOrder.SausageLink);
            foodOrder.SausageLink = false;
            Assert.False(foodOrder.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton foodOrder = new SmokehouseSkeleton();
            foodOrder.Egg = true;
            Assert.True(foodOrder.Egg);
            foodOrder.Egg = false;
            Assert.False(foodOrder.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton foodOrder = new SmokehouseSkeleton();
            foodOrder.HashBrowns = true;
            Assert.True(foodOrder.HashBrowns);
            foodOrder.HashBrowns = false;
            Assert.False(foodOrder.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton foodOrder = new SmokehouseSkeleton();
            foodOrder.Pancake = true;
            Assert.True(foodOrder.Pancake);
            foodOrder.Pancake = false;
            Assert.False(foodOrder.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton foodOrder = new SmokehouseSkeleton();
            Assert.Equal(5.62, foodOrder.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        { 
            SmokehouseSkeleton foodOrder = new SmokehouseSkeleton();
            Assert.Equal((uint)602, foodOrder.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton foodOrder = new SmokehouseSkeleton();
            foodOrder.SausageLink = includeSausage;
            foodOrder.Egg = includeEgg;
            foodOrder.HashBrowns = includeHashbrowns;
            foodOrder.Pancake = includePancake;


            if (!includeSausage) Assert.Contains("Hold sausage", foodOrder.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold eggs", foodOrder.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", foodOrder.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancakes", foodOrder.SpecialInstructions);
            else Assert.Empty(foodOrder.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton foodOrder = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", foodOrder.ToString());
        }

        [Fact]
        public void ChangingSausageLinkNotification()
        {
            var item = new SmokehouseSkeleton();
            Assert.PropertyChanged(item, "SausageLink", () =>
            {
                item.SausageLink = false;
            });
            Assert.PropertyChanged(item, "SausageLink", () =>
            {
                item.SausageLink = true;
            });
        }

        [Fact]
        public void ChangingEggLinkNotification()
        {
            var item = new SmokehouseSkeleton();
            Assert.PropertyChanged(item, "Egg", () =>
            {
                item.Egg = false;
            });
            Assert.PropertyChanged(item, "Egg", () =>
            {
                item.Egg = true;
            });
        }
        [Fact]
        public void ChangingHashBrownsLinkNotification()
        {
            var item = new SmokehouseSkeleton();
            Assert.PropertyChanged(item, "HashBrowns", () =>
            {
                item.HashBrowns = false;
            });
            Assert.PropertyChanged(item, "HashBrowns", () =>
            {
                item.HashBrowns = true;
            });
        }
        [Fact]
        public void ChangingPancakeLinkNotification()
        {
            var item = new SmokehouseSkeleton();
            Assert.PropertyChanged(item, "Pancake", () =>
            {
                item.Pancake = false;
            });
            Assert.PropertyChanged(item, "Pancake", () =>
            {
                item.Pancake = true;
            });
        }
    }
}