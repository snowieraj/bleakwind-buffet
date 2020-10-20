using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Menu;
using PointOfSale.Register;
using RoundRegister;

namespace PointOfSaleTests
{
    public class RegisterViewModelTests
    {
        [Fact]
        public void ShouldBeACashRegister()
        {
            RegisterModelView view = new RegisterModelView(null, null);
            Assert.IsAssignableFrom<RegisterModelView>(view);
        }

        [Fact]
        public void ChangeHundredPaymentNotifyAmountOwed()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            RegisterModelView view = new RegisterModelView(order, null);

            order.Add(aa);
            Assert.PropertyChanged(view, "CustomerHundreds", () => view.CustomerHundreds++);
            Assert.PropertyChanged(view, "AmountOwed", () => view.CustomerHundreds++);
            Assert.PropertyChanged(view, "ChangeDue", () => view.CustomerHundreds++);
            Assert.PropertyChanged(view, "AmountOwedOnTicket", () => view.CustomerHundreds++);

        }

        [Fact]
        public void ChangeFiftyPaymentNotifyFifty()
        {
            Order order = new Order();
            BriarheartBurger foodItem = new BriarheartBurger();
            order.Add(foodItem);
            RegisterModelView view = new RegisterModelView(order, null);

            Assert.PropertyChanged(view, "CustomerFifty", () => view.CustomerFifty++);

        }
        [Fact]
        public void ChangeTwentyPaymentNotifyTwenty()
        {
            Order order = new Order();
            BriarheartBurger foodItem = new BriarheartBurger();
            order.Add(foodItem);
            RegisterModelView view = new RegisterModelView(order, null);

            Assert.PropertyChanged(view, "CustomerTwenty", () => view.CustomerTwenty++);

        }
        [Fact]
        public void ChangeTenPaymentNotifyTen()
        {
            Order order = new Order();
            BriarheartBurger foodItem = new BriarheartBurger();
            order.Add(foodItem);
            RegisterModelView view = new RegisterModelView(order, null);

            Assert.PropertyChanged(view, "CustomerTen", () => view.CustomerTen++);

        }
        [Fact]
        public void ChangeFivePaymentNotifyFive()
        {
            Order order = new Order();
            BriarheartBurger foodItem = new BriarheartBurger();
            order.Add(foodItem);
            RegisterModelView view = new RegisterModelView(order, null);

            Assert.PropertyChanged(view, "CustomerFive", () => view.CustomerFive++);

        }
        [Fact]
        public void ChangeOnePaymentNotifyOne()
        {
            Order order = new Order();
            BriarheartBurger foodItem = new BriarheartBurger();
            order.Add(foodItem);
            RegisterModelView view = new RegisterModelView(order, null);

            Assert.PropertyChanged(view, "CustomerOne", () => view.CustomerOne++);

        }
        [Fact]
        public void ChangeDollarPaymentNotifyDollar ()
        {
            Order order = new Order();
            BriarheartBurger foodItem = new BriarheartBurger();
            order.Add(foodItem);
            RegisterModelView view = new RegisterModelView(order, null);

            Assert.PropertyChanged(view, "CustomerDollarCoin", () => view.CustomerDollarCoin++);

        }
        [Fact]
        public void ChangeHalfDollarPaymentNotifyHalfDollar()
        {
            Order order = new Order();
            BriarheartBurger foodItem = new BriarheartBurger();
            order.Add(foodItem);
            RegisterModelView view = new RegisterModelView(order, null);

            Assert.PropertyChanged(view, "CustomerHalfDollar", () => view.CustomerHalfDollar++);

        }
        [Fact]
        public void ChangeQuarterPaymentNotifyQuarter()
        {
            Order order = new Order();
            BriarheartBurger foodItem = new BriarheartBurger();
            order.Add(foodItem);
            RegisterModelView view = new RegisterModelView(order, null);

            Assert.PropertyChanged(view, "CustomerQuarter", () => view.CustomerQuarter++);

        }
        [Fact]
        public void ChangeDimePaymentNotifyDime()
        {
            Order order = new Order();
            BriarheartBurger foodItem = new BriarheartBurger();
            order.Add(foodItem);
            RegisterModelView view = new RegisterModelView(order, null);

            Assert.PropertyChanged(view, "CustomerDimes", () => view.CustomerDimes++);

        }
        [Fact]
        public void ChangeNickelPaymentNotifyNickel()
        {
            Order order = new Order();
            BriarheartBurger foodItem = new BriarheartBurger();
            order.Add(foodItem);
            RegisterModelView view = new RegisterModelView(order, null);

            Assert.PropertyChanged(view, "CustomerNickel", () => view.CustomerNickel++);

        }

        [Fact]
        public void ChangePennyPaymentNotifyPenny()
        {
            Order order = new Order();
            BriarheartBurger foodItem = new BriarheartBurger();
            order.Add(foodItem);
            RegisterModelView view = new RegisterModelView(order, null);

            Assert.PropertyChanged(view, "CustomerPenny", () => view.CustomerPenny++);

        }

        [Theory]
        [InlineData(8.24)]
        public void RetrieveAmountDue(double amount)
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            order.Add(bb);
            order.Add(aa);
            order.Add(dw);
            RegisterModelView view = new RegisterModelView(order, null);
            Assert.Equal(amount, Math.Round((view.AmountOwed), 2));
        }

        [Theory]
        [InlineData(8.24)]
        public void RetrieveAmountDueOnTicket(double amount)
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            order.Add(bb);
            order.Add(aa);
            order.Add(dw);
            RegisterModelView view = new RegisterModelView(order, null);
            Assert.Equal(amount, Math.Round((view.AmountOwedOnTicket), 2));
        }

        
        [Theory]
        [InlineData(91.28, 1)]
        public void ShouldCalculateChangeDue(double change, int payment)
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk aa = new MarkarthMilk();
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            order.Add(bb);
            order.Add(aa);
            order.Add(dw);
            RegisterModelView view = new RegisterModelView(order, null);

            view.ChangeOwedToCustomer();
            view.CustomerHundreds = payment;

            Assert.Equal(change, Math.Round(view.ChangeDue, 2));
            Assert.Equal(0, view.ChangeInHundreds);
            Assert.Equal(0, view.ChangeInFifties);
            Assert.Equal(1, view.ChangeInTwenties);
            Assert.Equal(0, view.ChangeInTens);
            Assert.Equal(0, view.ChangeInFives);
            Assert.Equal(0, view.ChangeInTwos);
            Assert.Equal(0, view.ChangeInOnes);
            Assert.Equal(0, view.ChangeInDollarCoins);
            Assert.Equal(0, view.ChangeInHalfDollars);
            Assert.Equal(0, view.ChangeInQuarters);
            Assert.Equal(0, view.ChangeInDimes);
            Assert.Equal(0, view.ChangeInNickels);
            Assert.Equal(0, view.ChangeInPennies);

        }

        [Theory]
        [InlineData(1)]
        public void FinalizeOrderUpdatesRegister(int payment)
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk aa = new MarkarthMilk();
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            order.Add(bb);
            order.Add(aa);
            order.Add(dw);
            RegisterModelView view = new RegisterModelView(order, null);

            view.ChangeOwedToCustomer();
            view.CustomerHundreds = payment;
            view.CompleteOrder();

            Assert.Equal(1, view.HundredsInRegister);
            Assert.Equal(0, view.FiftyInRegister);
            Assert.Equal(4, view.TwentyInRegister);
            Assert.Equal(10, view.TenInRegister);
            Assert.Equal(4, view.FiveInRegister);
            Assert.Equal(0, view.TwoInRegister);
            Assert.Equal(20, view.OneInRegister);
            Assert.Equal(0, view.DollarCoinInRegister);
            Assert.Equal(0, view.HalfDollarInRegister);
            Assert.Equal(80, view.QuarterInRegister);
            Assert.Equal(100, view.DimeInRegister);
            Assert.Equal(80, view.NickelInRegister);
            Assert.Equal(200, view.PennyInRegister);

            Assert.Equal(0, view.CustomerHundreds);
            Assert.Equal(0, view.CustomerFifty);
            Assert.Equal(0, view.CustomerTwenty);
            Assert.Equal(0, view.CustomerTen);
            Assert.Equal(0, view.CustomerFive);
            Assert.Equal(0, view.CustomerTwo);
            Assert.Equal(0, view.CustomerOne);
            Assert.Equal(0, view.CustomerDollarCoin);
            Assert.Equal(0, view.CustomerHalfDollar);
            Assert.Equal(0, view.CustomerQuarter);
            Assert.Equal(0, view.CustomerDimes);
            Assert.Equal(0, view.CustomerNickel);
            Assert.Equal(0, view.CustomerPenny);
        }
        

    }
}
