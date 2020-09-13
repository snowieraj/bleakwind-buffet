﻿/*
* Author: Andrew Yi
* Class name: Menu.cs
* Purpose: Menu Items
*/
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data.Menu
{
    /// <summary>
    /// Menu items 
    /// </summary>
    public static class Menu
    {  
        /// <summary>
        /// All entree items
        /// </summary>
        /// <returns>List of entree items</returns>
      public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new BriarheartBurger());
            list.Add(new DoubleDraugr());
            list.Add(new GardenOrcOmelette());
            list.Add(new PhillyPoacher());
            list.Add(new SmokehouseSkeleton());
            list.Add(new ThalmorTriple());
            list.Add(new ThugsTBone());
            return list;
        }
        /// <summary>
        /// All side items
        /// </summary>
        /// <returns>List of side items</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> list = new List<IOrderItem>();

            list.Add(new DragonbornWaffleFries());
            DragonbornWaffleFries m1 = new DragonbornWaffleFries();
            DragonbornWaffleFries l1 = new DragonbornWaffleFries(); 
            m1.Size = Size.Medium;
            l1.Size = Size.Large;
            list.Add(m1);
            list.Add(l1);

            list.Add(new FriedMiraak());
            FriedMiraak m2 = new FriedMiraak();
            FriedMiraak l2 = new FriedMiraak();
            m2.Size = Size.Medium;
            l2.Size = Size.Large;
            list.Add(m2);
            list.Add(l2);

            list.Add(new MadOtarGrits());
            MadOtarGrits m3 = new MadOtarGrits();
            MadOtarGrits l3 = new MadOtarGrits();
            m3.Size = Size.Medium;
            l3.Size = Size.Large;
            list.Add(m3);
            list.Add(l3);

            list.Add(new VokunSalad());
            VokunSalad m4 = new VokunSalad();
            VokunSalad l4 = new VokunSalad();
            m4.Size = Size.Medium;
            l4.Size = Size.Large;
            list.Add(m4);
            list.Add(l4);
            
            return list;
        }
        /// <summary>
        /// All drink items
        /// </summary>
        /// <returns>List of drink items</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {


            List<IOrderItem> list = new List<IOrderItem>();

            list.Add(new AretinoAppleJuice());
            AretinoAppleJuice m1 = new AretinoAppleJuice();
            AretinoAppleJuice l1 = new AretinoAppleJuice();
            m1.Size = Size.Medium;
            l1.Size = Size.Large;
            list.Add(m1);
            list.Add(l1);

            list.Add(new CandlehearthCoffee());
            CandlehearthCoffee m2 = new CandlehearthCoffee();
            CandlehearthCoffee l2 = new CandlehearthCoffee();
            CandlehearthCoffee d1 = new CandlehearthCoffee();
            CandlehearthCoffee d2 = new CandlehearthCoffee();
            CandlehearthCoffee d3 = new CandlehearthCoffee();
            m2.Size = Size.Medium;
            l2.Size = Size.Large;
            list.Add(m2);
            list.Add(l2);

            d1.Decaf = true;
            d1.Size = Size.Small;
            list.Add(d1);
            d2.Decaf = true;
            d2.Size = Size.Medium;
            list.Add(d2);
            d3.Decaf = true;
            d3.Size = Size.Large;
            list.Add(d3);

            list.Add(new MarkarthMilk());
            MarkarthMilk m3 = new MarkarthMilk();
            MarkarthMilk l3 = new MarkarthMilk();
            m3.Size = Size.Medium;
            l3.Size = Size.Large;
            list.Add(m3);
            list.Add(l3);

            //Blackberry - Default/Small
            SailorSoda smallBlackBerry = new SailorSoda();//Small
            smallBlackBerry.Size = Size.Small;
            smallBlackBerry.Flavor = SodaFlavor.Blackberry;
            list.Add(smallBlackBerry);
            SailorSoda medBlackBerry = new SailorSoda();
            medBlackBerry.Size = Size.Medium;
            medBlackBerry.Flavor = SodaFlavor.Blackberry;
            list.Add(medBlackBerry);
            SailorSoda larBlackberry = new SailorSoda();
            larBlackberry.Flavor = SodaFlavor.Blackberry;
            larBlackberry.Size = Size.Large;
            list.Add(larBlackberry);
            //Cherry
            SailorSoda smallCherry = new SailorSoda();
            smallCherry.Flavor = SodaFlavor.Cherry;
            smallCherry.Size = Size.Small;
            list.Add(smallCherry);
            SailorSoda medCherry = new SailorSoda();
            medCherry.Flavor = SodaFlavor.Cherry;
            medCherry.Size = Size.Medium;
            list.Add(medCherry);
            SailorSoda larCherry = new SailorSoda();
            larCherry.Flavor = SodaFlavor.Cherry;
            larCherry.Size = Size.Large;
            list.Add(larCherry);
            //Grapefruit
            SailorSoda smaGrape = new SailorSoda();
            smaGrape.Flavor = SodaFlavor.Grapefruit;
            smaGrape.Size = Size.Small;
            list.Add(smaGrape);
            SailorSoda medGrape = new SailorSoda();
            medGrape.Flavor = SodaFlavor.Grapefruit;
            medGrape.Size = Size.Medium;
            list.Add(medGrape);
            SailorSoda larGrape = new SailorSoda();
            larGrape.Flavor = SodaFlavor.Grapefruit;
            larGrape.Size = Size.Large;
            list.Add(larGrape);
            //Lemon
            SailorSoda smaLemon = new SailorSoda();
            smaLemon.Flavor = SodaFlavor.Lemon;
            smaLemon.Size = Size.Small;
            list.Add(smaLemon);
            SailorSoda medLemon = new SailorSoda();
            medLemon.Flavor = SodaFlavor.Lemon;
            medLemon.Size = Size.Medium;
            list.Add(medLemon);
            SailorSoda larLemon = new SailorSoda();
            larLemon.Flavor = SodaFlavor.Lemon;
            larLemon.Size = Size.Large;
            list.Add(larLemon);
            //Peach
            SailorSoda smaPeach = new SailorSoda();
            smaPeach.Flavor = SodaFlavor.Peach;
            smaPeach.Size = Size.Small;
            list.Add(smaPeach);
            SailorSoda medPeach = new SailorSoda();
            medPeach.Flavor = SodaFlavor.Peach;
            medPeach.Size = Size.Medium;
            list.Add(medPeach);
            SailorSoda larPeach = new SailorSoda();
            larPeach.Flavor = SodaFlavor.Peach;
            larPeach.Size = Size.Large;
            list.Add(larPeach);
            //Watermelon
            SailorSoda smaWatermelon = new SailorSoda();
            smaWatermelon.Flavor = SodaFlavor.Watermelon;
            smaWatermelon.Size = Size.Small;
            list.Add(smaWatermelon);
            SailorSoda medWatermelon = new SailorSoda();
            medWatermelon.Flavor = SodaFlavor.Watermelon;
            medWatermelon.Size = Size.Medium;
            list.Add(medWatermelon);
            SailorSoda larWatermelon = new SailorSoda();
            larWatermelon.Flavor = SodaFlavor.Watermelon;
            larWatermelon.Size = Size.Large;
            list.Add(larWatermelon);

            WarriorWater s1 = new WarriorWater();
            list.Add(s1);
            WarriorWater m4 = new WarriorWater();
            m4.Size = Size.Medium;
            list.Add(m4);
            WarriorWater l4 = new WarriorWater();
            l4.Size = Size.Large;
            list.Add(l4);

            return list;
        }
        /// <summary>
        /// Full menu
        /// </summary>
        /// <returns>List of everything on the menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new BriarheartBurger());
            list.Add(new DoubleDraugr());
            list.Add(new GardenOrcOmelette());
            list.Add(new PhillyPoacher());
            list.Add(new SmokehouseSkeleton());
            list.Add(new ThalmorTriple());
            list.Add(new ThugsTBone());
            

            

            list.Add(new DragonbornWaffleFries());
            DragonbornWaffleFries m1 = new DragonbornWaffleFries();
            DragonbornWaffleFries l1 = new DragonbornWaffleFries();
            m1.Size = Size.Medium;
            l1.Size = Size.Large;
            list.Add(m1);
            list.Add(l1);

            list.Add(new FriedMiraak());
            FriedMiraak m2 = new FriedMiraak();
            FriedMiraak l2 = new FriedMiraak();
            m2.Size = Size.Medium;
            l2.Size = Size.Large;
            list.Add(m2);
            list.Add(l2);

            list.Add(new MadOtarGrits());
            MadOtarGrits m3 = new MadOtarGrits();
            MadOtarGrits l3 = new MadOtarGrits();
            m3.Size = Size.Medium;
            l3.Size = Size.Large;
            list.Add(m3);
            list.Add(l3);

            list.Add(new VokunSalad());
            VokunSalad m4 = new VokunSalad();
            VokunSalad l4 = new VokunSalad();
            m4.Size = Size.Medium;
            l4.Size = Size.Large;
            list.Add(m4);
            list.Add(l4);

            

            

            list.Add(new AretinoAppleJuice());
            AretinoAppleJuice m1a = new AretinoAppleJuice();
            AretinoAppleJuice l1a = new AretinoAppleJuice();
            m1a.Size = Size.Medium;
            l1a.Size = Size.Large;
            list.Add(m1a);
            list.Add(l1a);

            list.Add(new CandlehearthCoffee());
            CandlehearthCoffee m2c = new CandlehearthCoffee();
            CandlehearthCoffee l2c = new CandlehearthCoffee();
            CandlehearthCoffee d1 = new CandlehearthCoffee();
            CandlehearthCoffee d2 = new CandlehearthCoffee();
            CandlehearthCoffee d3 = new CandlehearthCoffee();
            m2c.Size = Size.Medium;
            l2c.Size = Size.Large;
            list.Add(m2c);
            list.Add(l2c);

            d1.Decaf = true;
            d1.Size = Size.Small;
            list.Add(d1);
            d2.Decaf = true;
            d2.Size = Size.Medium;
            list.Add(d2);
            d3.Decaf = true;
            d3.Size = Size.Large;
            list.Add(d3);

            list.Add(new MarkarthMilk());
            MarkarthMilk m6 = new MarkarthMilk();
            MarkarthMilk l6 = new MarkarthMilk();
            m6.Size = Size.Medium;
            l6.Size = Size.Large;
            list.Add(m6);
            list.Add(l6);

            //Blackberry - Default/Small
            SailorSoda smallBlackBerry = new SailorSoda();//Small
            smallBlackBerry.Size = Size.Small;
            smallBlackBerry.Flavor = SodaFlavor.Blackberry;
            list.Add(smallBlackBerry);
            SailorSoda medBlackBerry = new SailorSoda();
            medBlackBerry.Size = Size.Medium;
            medBlackBerry.Flavor = SodaFlavor.Blackberry;
            list.Add(medBlackBerry);
            SailorSoda larBlackberry = new SailorSoda();
            larBlackberry.Flavor = SodaFlavor.Blackberry;
            larBlackberry.Size = Size.Large;
            list.Add(larBlackberry);
            //Cherry
            SailorSoda smallCherry = new SailorSoda();
            smallCherry.Flavor = SodaFlavor.Cherry;
            smallCherry.Size = Size.Small;
            list.Add(smallCherry);
            SailorSoda medCherry = new SailorSoda();
            medCherry.Flavor = SodaFlavor.Cherry;
            medCherry.Size = Size.Medium;
            list.Add(medCherry);
            SailorSoda larCherry = new SailorSoda();
            larCherry.Flavor = SodaFlavor.Cherry;
            larCherry.Size = Size.Large;
            list.Add(larCherry);
            //Grapefruit
            SailorSoda smaGrape = new SailorSoda();
            smaGrape.Flavor = SodaFlavor.Grapefruit;
            smaGrape.Size = Size.Small;
            list.Add(smaGrape);
            SailorSoda medGrape = new SailorSoda();
            medGrape.Flavor = SodaFlavor.Grapefruit;
            medGrape.Size = Size.Medium;
            list.Add(medGrape);
            SailorSoda larGrape = new SailorSoda();
            larGrape.Flavor = SodaFlavor.Grapefruit;
            larGrape.Size = Size.Large;
            list.Add(larGrape);
            //Lemon
            SailorSoda smaLemon = new SailorSoda();
            smaLemon.Flavor = SodaFlavor.Lemon;
            smaLemon.Size = Size.Small;
            list.Add(smaLemon);
            SailorSoda medLemon = new SailorSoda();
            medLemon.Flavor = SodaFlavor.Lemon;
            medLemon.Size = Size.Medium;
            list.Add(medLemon);
            SailorSoda larLemon = new SailorSoda();
            larLemon.Flavor = SodaFlavor.Lemon;
            larLemon.Size = Size.Large;
            list.Add(larLemon);
            //Peach
            SailorSoda smaPeach = new SailorSoda();
            smaPeach.Flavor = SodaFlavor.Peach;
            smaPeach.Size = Size.Small;
            list.Add(smaPeach);
            SailorSoda medPeach = new SailorSoda();
            medPeach.Flavor = SodaFlavor.Peach;
            medPeach.Size = Size.Medium;
            list.Add(medPeach);
            SailorSoda larPeach = new SailorSoda();
            larPeach.Flavor = SodaFlavor.Peach;
            larPeach.Size = Size.Large;
            list.Add(larPeach);
            //Watermelon
            SailorSoda smaWatermelon = new SailorSoda();
            smaWatermelon.Flavor = SodaFlavor.Watermelon;
            smaWatermelon.Size = Size.Small;
            list.Add(smaWatermelon);
            SailorSoda medWatermelon = new SailorSoda();
            medWatermelon.Flavor = SodaFlavor.Watermelon;
            medWatermelon.Size = Size.Medium;
            list.Add(medWatermelon);
            SailorSoda larWatermelon = new SailorSoda();
            larWatermelon.Flavor = SodaFlavor.Watermelon;
            larWatermelon.Size = Size.Large;
            list.Add(larWatermelon);

            WarriorWater s1 = new WarriorWater();
            list.Add(s1);
            WarriorWater m5 = new WarriorWater();
            m5.Size = Size.Medium;
            list.Add(m5);
            WarriorWater l5 = new WarriorWater();
            l5.Size = Size.Large;
            list.Add(l5);

            return list;
        }

    }
}