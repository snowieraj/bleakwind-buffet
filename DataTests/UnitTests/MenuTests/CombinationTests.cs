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

       
    }
}
