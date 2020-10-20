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
using System.Reflection.PortableExecutable;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.MenuTests
{
    public class OrderTests
    {
        [Fact]
        public void AddToOrder()
        {
            Order orderItems = new Order();
            BriarheartBurger entreeItem = new BriarheartBurger();
            AretinoAppleJuice drinkItem = new AretinoAppleJuice();
            DragonbornWaffleFries sideItem = new DragonbornWaffleFries();
            orderItems.Add(entreeItem);
            orderItems.Add(drinkItem);
            orderItems.Add(sideItem);
            Assert.Contains(entreeItem, orderItems);
            Assert.Contains(drinkItem, orderItems);
            Assert.Contains(sideItem, orderItems);
        }
        [Fact]
        public void AddingAnItemShouldChangeCalories()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Add(bb);
            });
        }

        [Fact]
        public void RemoveFromOrder()
        {
            Order orderItems = new Order();
            BriarheartBurger entreeItem = new BriarheartBurger();
            AretinoAppleJuice drinkItem = new AretinoAppleJuice();
            DragonbornWaffleFries sideItem = new DragonbornWaffleFries();
            orderItems.Add(entreeItem);
            orderItems.Add(drinkItem);
            orderItems.Add(sideItem);
            Assert.Contains(entreeItem, orderItems);
            Assert.Contains(drinkItem, orderItems);
            Assert.Contains(sideItem, orderItems);
            orderItems.Remove(entreeItem);
            orderItems.Remove(drinkItem);
            orderItems.Remove(sideItem);
            Assert.DoesNotContain(entreeItem, orderItems);
            Assert.DoesNotContain(drinkItem, orderItems);
            Assert.DoesNotContain(sideItem, orderItems);

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

        [Fact]
        public void ShouldBeAnOrder()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<Order>(order);
        }

        [Fact]
        public void AddingAnItemShouldChangeTotal()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Add(bb);
            });
        }
        [Fact]
        public void AddingAnItemShouldChangeTax()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Add(bb);
            });
        }

        [Fact]
        public void AddingAnItemShouldChangeSubtotal()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(bb);
            });
        }
        [Fact]
        public void RemovingAnItemShouldChangeCalories()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Remove(bb);
            });
        }

        [Fact]
        public void ShouldAddToOrder()
        {
            Order o = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            FriedMiraak fm = new FriedMiraak();
            Combination c = new Combination(bb, fm, mm);
            o.Add(bb);
            o.Add(mm);
            o.Add(fm);
            o.Add(c);
            Assert.Contains(bb, o);
            Assert.Contains(mm, o);
            Assert.Contains(fm, o);
            Assert.Contains(c, o);
        }

        [Fact]
        public void ShouldRemoveItemFromOrder()
        {
            Order o = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            FriedMiraak fm = new FriedMiraak();
            Combination c = new Combination(bb, fm, mm);
            o.Add(bb);
            o.Add(mm);
            o.Add(fm);
            o.Add(c);
            Assert.Contains(bb, o);
            Assert.Contains(fm, o);
            Assert.Contains(mm, o);
            Assert.Contains(c, o);
            o.Remove(bb);
            o.Remove(fm);
            o.Remove(mm);
            o.Remove(c);
            Assert.DoesNotContain(bb, o);
            Assert.DoesNotContain(fm, o);
        }

        [Fact]
        public void SalesTaxShouldBeDefault()
        {
            Order order = new Order();
            Assert.Equal(.12, order.SalesTaxRate);
        }

        [Theory]
        [InlineData(Size.Large, 7.54)]
        [InlineData(Size.Medium, 7.43)]
        [InlineData(Size.Small, 7.37)]
        public void ShouldGetSubtotal(Size size, double sub)
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            order.Add(bb);
            order.Add(mm);
            Assert.Equal(sub, Math.Round(order.Subtotal, 2));
        }

        [Theory]
        [InlineData(Size.Large, 8.44)]
        [InlineData(Size.Medium, 8.32)]
        [InlineData(Size.Small, 8.25)]
        public void ShouldGetTotal(Size size, double total)
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            order.Add(bb);
            order.Add(mm);
            Assert.Equal(total, Math.Round(order.Total, 2));
        }

        [Theory]
        [InlineData(Size.Large, 0.90)]
        [InlineData(Size.Medium, 0.89)]
        [InlineData(Size.Small, 0.88)]
        public void ShouldGetTax(Size size, double tax)
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            order.Add(bb);
            order.Add(mm);
            Assert.Equal(tax, Math.Round(order.Tax, 2));
        }

        [Theory]
        [InlineData(0.50)]
        [InlineData(0.25)]
        public void ShouldSetSalesTaxRate(double salesTaxRate)
        {
            Order order = new Order();
            order.SalesTaxRate = salesTaxRate;
            Assert.Equal(salesTaxRate, Math.Round(order.SalesTaxRate, 2));
        }
        [Theory]
        [InlineData(Size.Large, 836)]
        [InlineData(Size.Medium, 815)]
        [InlineData(Size.Small, 799)]
        public void ShouldReturnTotalCaloriesOfOrder(Size size, uint cal)
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            order.Add(bb);
            order.Add(mm);
            Assert.Equal(cal, order.Calories);
        }

        [Theory]
        [InlineData(3)]
        public void ShouldGetCountOfItemsInOrder(int count)
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            order.Add(bb);
            order.Add(mm);
            order.Add(dwf);
            Assert.Equal(count, order.Count);
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ShouldClearOrder(Size size)
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            order.Add(bb);
            order.Add(mm);
            order.Clear();
            Assert.DoesNotContain(bb, order);
            Assert.DoesNotContain(mm, order);
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ShouldContainItems(Size size)
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            order.Add(mm);
            bool temp = order.Contains(mm);
            Assert.True(temp);
            temp = order.Contains(bb);
            Assert.False(temp);
        }

    }
}
