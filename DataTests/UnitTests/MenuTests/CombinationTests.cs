using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Menu;
using Xunit;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.MenuTests
{
    public class CombinationTests
    {

        
        [Fact]
        public void ShouldChangeEntreeSelected()
        {
            BriarheartBurger bb = new BriarheartBurger();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Combination combo = new Combination(bb, dw, aa);
            Assert.PropertyChanged(combo, "Entree", () => combo.Entree = new GardenOrcOmelette());
        }


        [Fact]
        public void ShouldChangeDrinkSelected()
        {
            BriarheartBurger bb = new BriarheartBurger();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Combination combo = new Combination(bb, dw, aa);
            Assert.PropertyChanged(combo, "Drink", () => combo.Drink = new WarriorWater());
        }

        [Fact]
        public void ShouldChangeSideSelected()
        {
            BriarheartBurger bb = new BriarheartBurger();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Combination combo = new Combination(bb, dw, aa);
            Assert.PropertyChanged(combo, "Side", () => combo.Side = new MadOtarGrits());
        }


        [Fact]
        public void PropertyChangedForSetsAdd()
        {
            Order item = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(item, "Total", () => item.Add(bb));
        }

        [Fact]
        public void ShouldReturnCorrectItemString()
        {
            FriedMiraak fm = new FriedMiraak();
            MarkarthMilk mm = new MarkarthMilk();
            BriarheartBurger bb = new BriarheartBurger();
            mm.Size = Data.Enums.Size.Large;
            fm.Size = Size.Medium;
            Combination item = new Combination(bb, fm, mm);
            Assert.Contains("Large Markarth Milk", item.SpecialInstructions);
            Assert.Contains("Medium Fried Miraak", item.SpecialInstructions);
            Assert.Contains("Briarheart Burger", item.SpecialInstructions);
        }

        [Fact]
        public void ShouldBeAComboination()
        {
            FriedMiraak fm = new FriedMiraak();
            MarkarthMilk mm = new MarkarthMilk();
            BriarheartBurger bb = new BriarheartBurger();
            fm.Size = Size.Medium;
            Combination combo = new Combination(bb, fm, mm);
            Assert.IsAssignableFrom<Combination>(combo);
        }

        [Fact]
        public void ShoudlGetEntree()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Combination combo = new Combination(bb, null, null);
            Assert.Equal(combo.Entree, bb);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldGetSide(Size size)
        {
            MadOtarGrits mm = new MadOtarGrits();
            mm.Size = size;
            Combination combo = new Combination(null, mm, null);
            Assert.Equal(combo.Side, mm);
        }


        [Theory]
        [InlineData(Size.Large, 1142)]
        [InlineData(Size.Medium, 1051)]
        [InlineData(Size.Small, 950)]
        public void ShouldTotalWholeCombosCaloriesBasedOnSize(Size size, uint cal)
        {
            FriedMiraak fm = new FriedMiraak();
            MarkarthMilk mm = new MarkarthMilk();
            BriarheartBurger bb = new BriarheartBurger();
            fm.Size = size;
            mm.Size = size;
            Combination c = new Combination(bb, fm, mm);
            Assert.Equal(cal, c.Calories);
        }

        [Theory]
        [InlineData(Size.Large, 10.42)]
        [InlineData(Size.Medium, 9.44)]
        [InlineData(Size.Small, 9.15)]
        public void ShouldGetTotalPriceOfComboBasedOnSize(Size size, double price)
        {
            FriedMiraak fm = new FriedMiraak();
            MarkarthMilk mm = new MarkarthMilk();
            BriarheartBurger bb = new BriarheartBurger();
            fm.Size = size;
            mm.Size = size;
            Combination c = new Combination(bb, fm, mm);
            Assert.Equal(price, Math.Round(c.Price, 2));
        }

        [Theory]
        [InlineData(true, Size.Small)]
        [InlineData(true, Size.Medium)]
        [InlineData(true, Size.Large)]
        [InlineData(false, Size.Small)]
        [InlineData(false, Size.Medium)]
        [InlineData(false, Size.Large)]
        public void ShouldGetSpecialInstructionsOfCombo(bool specialInstructions, Size size)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Combination c = new Combination(bb, dwf, aj);
            aj.Ice = specialInstructions;
            bb.Bun = specialInstructions;
            aj.Size = size;
            dwf.Size = size;
            if (specialInstructions && size == Size.Small)
            {
                Assert.Contains("Briarheart Burger", c.SpecialInstructions);
                Assert.Contains("Small Aretino Apple Juice", c.SpecialInstructions);
                Assert.Contains("Small Dragonborn Waffle Fries", c.SpecialInstructions);
                Assert.Contains("Add ice", c.SpecialInstructions);
            }
            else if (specialInstructions && size == Size.Medium)
            {
                Assert.Contains("Briarheart Burger", c.SpecialInstructions);
                Assert.Contains("Medium Aretino Apple Juice", c.SpecialInstructions);
                Assert.Contains("Medium Dragonborn Waffle Fries", c.SpecialInstructions);
                Assert.Contains("Add ice", c.SpecialInstructions);
            }
            else if (specialInstructions && size == Size.Large)
            {
                Assert.Contains("Briarheart Burger", c.SpecialInstructions);
                Assert.Contains("Large Aretino Apple Juice", c.SpecialInstructions);
                Assert.Contains("Large Dragonborn Waffle Fries", c.SpecialInstructions);
                Assert.Contains("Add ice", c.SpecialInstructions);
            }
            else if (!(specialInstructions) && size == Size.Small)
            {
                Assert.Contains("Briarheart Burger", c.SpecialInstructions);
                Assert.Contains("Small Aretino Apple Juice", c.SpecialInstructions);
                Assert.Contains("Small Dragonborn Waffle Fries", c.SpecialInstructions);
                Assert.Contains("Hold bun", c.SpecialInstructions);
            }
            else if (!(specialInstructions) && size == Size.Medium)
            {
                Assert.Contains("Briarheart Burger", c.SpecialInstructions);
                Assert.Contains("Medium Aretino Apple Juice", c.SpecialInstructions);
                Assert.Contains("Medium Dragonborn Waffle Fries", c.SpecialInstructions);
                Assert.Contains("Hold bun", c.SpecialInstructions);
            }
            else if (!(specialInstructions) && size == Size.Large)
            {
                Assert.Contains("Briarheart Burger", c.SpecialInstructions);
                Assert.Contains("Large Aretino Apple Juice", c.SpecialInstructions);
                Assert.Contains("Large Dragonborn Waffle Fries", c.SpecialInstructions);
                Assert.Contains("Hold bun", c.SpecialInstructions);
            }
        }



    }
}
