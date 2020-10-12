/*
 * Author: Andrew Yi
 * Class: OrderTest.cs
 * Purpose: Test the menu items
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.Threading.Channels;
using BleakwindBuffet.Data.Drinks;
using NuGet.Frameworks;
using System.Collections.Specialized;
using System.Linq;

namespace BleakwindBuffet.DataTests.UnitTests.MenuTests
{
    public class OrderTests
    {
        [Fact]
        public void AddToOrder()
        {
            Order orderItems = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            orderItems.Add(bb);
            orderItems.Add(aa);
            orderItems.Add(dw);
            Assert.Contains(bb, orderItems);
            Assert.Contains(aa, orderItems);
            Assert.Contains(dw, orderItems);
        }

        [Fact]
        public void RemoveFromOrder()
        {
            Order orderItems = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            orderItems.Add(bb);
            orderItems.Add(aa);
            orderItems.Add(dw);
            Assert.Contains(bb, orderItems);
            Assert.Contains(aa, orderItems);
            Assert.Contains(dw, orderItems);
            orderItems.Remove(bb);
            orderItems.Remove(aa);
            orderItems.Remove(dw);
            Assert.DoesNotContain(bb, orderItems);
            Assert.DoesNotContain(aa, orderItems);
            Assert.DoesNotContain(dw, orderItems);

        }
        
        [Fact]
        public void PropertyChangedForSetsAdd()
        {
            Order item = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(item, "Total", () => item.Add(bb));
        }

        [Fact]
        public void PropertyChangedForSetRemoval()
        {
            Order item = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            item.Add(bb);
            Assert.PropertyChanged(item, "Subtotal", () => item.Remove(bb));
        }

        [Fact]
        public void CollectionChangedForSet()
        {
            Order item = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            
        }
    }
}
