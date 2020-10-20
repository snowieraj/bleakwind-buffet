using BleakwindBuffet.Data.Menu;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows;

namespace PointOfSale.Register
{
    public class RegisterModelView : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Ordered item
        /// </summary>
        private Order orderItem;
        //Register
        private CashRegister cashOption;
        /// <summary>
        /// Construct of MVVM
        /// </summary>
        /// <param name="order"></param>
        /// <param name="cash"></param>
        public RegisterModelView(Order order, CashRegister cash)
        {
            orderItem = order;
            cashOption = cash;
        }
        /// <summary>
        /// Total of the order
        /// </summary>
        public double Total => orderItem.Total;

        public double Payment
        {
            get => (CustomerHundreds * 100) + (CustomerFifty * 50) + (CustomerTwenty * 20) +
                (CustomerTen * 10) + (CustomerFive * 5) + (CustomerTwo * 2)  + (CustomerOne * 1) + (CustomerDollarCoin * 1) + (CustomerHalfDollar * .50) +
                (CustomerQuarter * .25) + (CustomerDimes * .10) + (CustomerNickel * .05) +
                (CustomerPenny * .01);
        }


        /// <summary>
        /// Amount owed on ticket
        /// </summary>
        public double AmountOwedOnTicket
        {
            get
            {
                if (AmountOwed < 0) return 0;
                else return AmountOwed;
            }
        }
        /// <summary>
        /// Amount owed that isnt payed off
        /// </summary>
        public double AmountOwed
        {
            get => Total - Payment;
        }
        /// <summary>
        /// Change Due when given money
        /// </summary>
        public double ChangeDue
        {
            get
            {
                if (Payment - AmountOwed > Total) return Math.Abs(AmountOwed);
                else return 0;
            }
        }
        /// <summary>
        /// Hundres in register
        /// </summary>
        public int HundredsInRegister
        {
            get
            {
                return CashDrawer.Hundreds;
            }
            set
            {
                CashDrawer.Hundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsInRegister"));
            }
        }

        /// <summary>
        /// Private and public variable for 100
        /// </summary>
        private int customerHundreds = 0;
        public int CustomerHundreds
        {
            get
            {
                return customerHundreds;
            }
            set
            {
                if (customerHundreds != value)
                {
                    customerHundreds = value;
                    ChangeOwedToCustomer();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerHundreds"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedOnTicket"));

                }
            }
        }
        /// <summary>
        /// Backing variable for hundreds for the customer
        /// </summary>
        private int changeInHundreds = 0;
        public int ChangeInHundreds => changeInHundreds;
        /// <summary>
        /// 50 in register
        /// </summary>
        public int FiftyInRegister
        {
            get
            {
                return CashDrawer.Fifties;
            }
            set
            {
                CashDrawer.Fifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftyInRegister"));
            }
        }
        /// <summary>
        /// Private and public variable for hundreds
        /// </summary>
        private int customerFifty = 0;
        public int CustomerFifty
        {
            get
            {
                return customerFifty;
            }
            set
            {
                if (customerFifty != value)
                {
                    customerFifty = value;
                    ChangeOwedToCustomer();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFifty"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedOnTicket"));

                }
            }
        }
        /// <summary>
        /// Backing variable for 50 for the customer
        /// </summary>
        private int changeInFifties = 0;
        public int ChangeInFifties => changeInFifties;
        /// <summary>
        /// 20 in register
        /// </summary>
        public int TwentyInRegister
        {
            get
            {
                return CashDrawer.Twenties;
            }
            set
            {
                CashDrawer.Twenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentyInRegister"));
            }
        }
        /// <summary>
        /// Private and public variable for twenty
        /// </summary>
        private int customerTwenty = 0;
        public int CustomerTwenty
        {
            get
            {
                return customerTwenty;
            }
            set
            {
                if (customerTwenty != value)
                {
                    customerTwenty = value;
                    ChangeOwedToCustomer();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwenty"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedOnTicket"));

                }
            }
        }
        /// <summary>
        /// Backing variable for 20 for the customer
        /// </summary>
        private int changeInTwenties = 0;
        public int ChangeInTwenties => changeInTwenties;
        /// <summary>
        /// 10 in register
        /// </summary>
        public int TenInRegister
        {
            get
            {
                return CashDrawer.Tens;
            }
            set
            {
                CashDrawer.Tens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TenInRegister"));
            }
        }
        /// <summary>
        /// Private and public variable for ten
        /// </summary>
        private int customerTen = 0;
        public int CustomerTen
        {
            get
            {
                return customerTen;
            }
            set
            {
                if (customerTen != value)
                {
                    customerTen = value;
                    ChangeOwedToCustomer();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTen"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedOnTicket"));

                }
            }
        }
        /// <summary>
        /// Backing variable for hundreds for the customer
        /// </summary>
        private int changeInTens = 0;
        public int ChangeInTens => changeInTens;
        /// <summary>
        /// 5 in register
        /// </summary>
        public int FiveInRegister
        {
            get
            {
                return CashDrawer.Fives;
            }
            set
            {
                CashDrawer.Fives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiveInRegister"));
            }
        }
        /// <summary>
        /// Private and public variable for 5
        /// </summary>
        private int customerFive = 0;
        public int CustomerFive
        {
            get
            {
                return customerFive;
            }
            set
            {
                if (customerFive != value)
                {
                    customerFive= value;
                    ChangeOwedToCustomer();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFive"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedOnTicket"));

                }
            }
        }
        /// <summary>
        /// Backing variable for 5 for the customer
        /// </summary>
        private int changeInFives= 0;
        public int ChangeInFives => changeInFives;
        /// <summary>
        /// 2 in register
        /// </summary>
        public int TwoInRegister
        {
            get
            {
                return CashDrawer.Twos;
            }
            set
            {
                CashDrawer.Twos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwoInRegister"));
            }
        }
        /// <summary>
        /// Private and public variable for 2
        /// </summary>
        private int customerTwo = 0;
        public int CustomerTwo
        {
            get
            {
                return customerTwo;
            }
            set
            {
                if (customerTwo != value)
                {
                    customerTwo = value;
                    ChangeOwedToCustomer();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwo"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedOnTicket"));

                }
            }
        }
        /// <summary>
        /// Backing variable for 2 for the customer
        /// </summary>
        private int changeInTwos = 0;
        public int ChangeInTwos => changeInTwos;
        /// <summary>
        /// 1 in register
        /// </summary>
        public int OneInRegister
        {
            get
            {
                return CashDrawer.Ones;
            }
            set
            {
                CashDrawer.Ones = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneInRegister"));
            }
        }
        /// <summary>
        /// Private and public variable for 1
        /// </summary>
        private int customerOne= 0;
        public int CustomerOne
        {
            get
            {
                return customerOne;
            }
            set
            {
                if (customerOne != value)
                {
                    customerOne= value;
                    ChangeOwedToCustomer();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerOne"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedOnTicket"));

                }
            }
        }
        /// <summary>
        /// Backing variable for hundreds for the customer
        /// </summary>
        private int changeInOnes = 0;
        public int ChangeInOnes => changeInOnes;

        public int DollarCoinInRegister
        {
            get
            {
                return CashDrawer.Dollars;
            }
            set
            {
                CashDrawer.Dollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarCoinInRegister"));
            }
        }
        /// <summary>
        /// Dollar coins
        /// </summary>
        private int customerDollarCoin;
        public int CustomerDollarCoin
        {
            get
            {
                return customerDollarCoin;
            }
            set
            {
                if (customerDollarCoin != value)
                {
                    customerDollarCoin = value;
                    ChangeOwedToCustomer();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerDollarCoin"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedOnTicket"));

                }
            }
        }
        private int changeInDollarCoins = 0;
        public int ChangeInDollarCoins => changeInDollarCoins;

        /// <summary>
        /// Dollar in register
        /// </summary>
        public int HalfDollarInRegister
        {
            get
            {
                return CashDrawer.HalfDollars;
            }
            set
            {
                CashDrawer.HalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarInRegister"));
            }
        }
        /// <summary>
        /// Private and public variable for dollar
        /// </summary>
        private int customerHalfDollar = 0;
        public int CustomerHalfDollar
        {
            get
            {
                return customerHalfDollar;
            }
            set
            {
                if (customerHalfDollar != value)
                {
                    customerHalfDollar = value;
                    ChangeOwedToCustomer();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerHalfDollar"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedOnTicket"));

                }
            }
        }
        /// <summary>
        /// Backing variable for half dollar for the customer
        /// </summary>
        private int changeInHalfDollars = 0;
        public int ChangeInHalfDollars => changeInHalfDollars;
        /// <summary>
        /// 50 c in register
        /// </summary>
        public int QuarterInRegister
        {
            get
            {
                return CashDrawer.Quarters;
            }
            set
            {
                CashDrawer.Quarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuarterInRegister"));
            }
        }
        /// <summary>
        /// Private and public variable for quarter
        /// </summary>
        private int customerQuarter= 0;
        public int CustomerQuarter
        {
            get
            {
                return customerQuarter;
            }
            set
            {
                if (customerQuarter != value)
                {
                    customerQuarter = value;
                    ChangeOwedToCustomer();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerQuarter"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedOnTicket"));

                }
            }
        }
        /// <summary>
        /// Backing variable for .50 for the customer
        /// </summary>
        private int changeInQuarters = 0;
        public int ChangeInQuarters => changeInQuarters;
        /// <summary>
        /// dime in register
        /// </summary>
        public int DimeInRegister
        {
            get
            {
                return CashDrawer.Dimes;
            }
            set
            {
                CashDrawer.Dimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimeInRegister"));
            }
        }
        /// <summary>
        /// Private and public variable for hundreds
        /// </summary>
        private int customerDimes = 0;
        public int CustomerDimes
        {
            get
            {
                return customerDimes;
            }
            set
            {
                if (customerDimes != value)
                {
                    customerDimes = value;
                    ChangeOwedToCustomer();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerDimes"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedOnTicket"));

                }
            }
        }
        /// <summary>
        /// Backing variable for half dollar for the customer
        /// </summary>
        private int changeInDimes = 0;
        public int ChangeInDimes=> changeInDimes;
        /// <summary>
        /// nickel in register
        /// </summary>
        public int NickelInRegister
        {
            get
            {
                return CashDrawer.Nickels;
            }
            set
            {
                CashDrawer.Nickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickelInRegister"));
            }
        }
        /// <summary>
        /// Private and public variable for nickel
        /// </summary>
        private int customerNickel = 0;
        public int CustomerNickel
        {
            get
            {
                return customerNickel;
            }
            set
            {
                if (customerNickel != value)
                {
                    customerNickel = value;
                    ChangeOwedToCustomer();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerNickel"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedOnTicket"));

                }
            }
        }
        /// <summary>
        /// Private and public variable for nickel
        /// </summary>
        private int changeInNickels = 0;
        public int ChangeInNickels => changeInNickels;
        /// <summary>
        /// penny in register
        /// </summary>
        public int PennyInRegister
        {
            get
            {
                return CashDrawer.Pennies;
            }
            set
            {
                CashDrawer.Pennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PennyInRegister"));
            }
        }
        /// <summary>
        /// Private and public variable for penny
        /// </summary>
        private int customerPenny = 0;
        public int CustomerPenny
        {
            get
            {
                return customerPenny;
            }
            set
            {
                if (customerPenny != value)
                {
                    customerPenny = value;
                    ChangeOwedToCustomer();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerPenny"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedOnTicket"));

                }
            }
        }
        /// <summary>
        /// Add payment to the register
        /// Give change back
        /// Reset payment
        /// </summary>
        public void CompleteOrder()
        {
            HundredsInRegister += CustomerHundreds;
            HundredsInRegister -= ChangeInHundreds;
            customerHundreds = 0;

            FiftyInRegister += CustomerFifty;
            FiftyInRegister -= ChangeInFifties;
            customerFifty = 0;

            TwentyInRegister += CustomerTwenty;
            TwentyInRegister -= ChangeInTwenties;
            customerTwenty = 0;

            TenInRegister += CustomerTen;
            TenInRegister -= ChangeInTens;
            customerTen = 0;

            FiveInRegister += CustomerFive;
            FiveInRegister -= ChangeInFives;
            customerFive = 0;

            OneInRegister += CustomerOne;
            OneInRegister -= ChangeInOnes;
            customerOne = 0;

            DollarCoinInRegister += CustomerDollarCoin;
            DollarCoinInRegister -= ChangeInDollarCoins;
            changeInDollarCoins = 0;

            HalfDollarInRegister += CustomerHalfDollar;
            HalfDollarInRegister -= ChangeInHalfDollars;
            changeInHalfDollars = 0;

            QuarterInRegister += CustomerQuarter;
            QuarterInRegister -= ChangeInQuarters;
            changeInQuarters = 0;

            DimeInRegister += CustomerDimes;
            DimeInRegister -= ChangeInDimes;
            changeInDimes = 0;

            NickelInRegister += CustomerNickel;
            NickelInRegister -= ChangeInNickels;
            changeInNickels = 0;

            PennyInRegister += CustomerPenny;
            PennyInRegister -= ChangeInPennies;
            changeInPennies = 0;
           

            ChangeOwedToCustomer();
            
        }

        /// <summary>
        /// Private and public variable for nickel
        /// </summary>
        private int changeInPennies = 0;
        public int ChangeInPennies => changeInPennies;
        public void ChangeOwedToCustomer()
        {
            double totalAmount = ChangeDue;
            double remainingAmount = totalAmount;
            int temp = HundredsInRegister;
            changeInHundreds = changeInFifties = changeInTwenties = changeInTens = changeInFives = changeInOnes = 0;
            changeInHalfDollars = changeInQuarters = changeInDimes = changeInNickels = changeInPennies = 0;

            while ((totalAmount % 100) < totalAmount && temp > 0)
            {
                if (totalAmount - 100 > 0)
                {
                    changeInHundreds++;
                    temp--;
                    remainingAmount = totalAmount - 100;
                    totalAmount = remainingAmount;
                }
            }
            temp = FiftyInRegister;
            while ((totalAmount % 50) < totalAmount && temp > 0)
            {
                if (totalAmount - 50 > 0)
                {
                    changeInFifties++;
                    temp--;
                    remainingAmount = totalAmount - 100;
                    totalAmount = remainingAmount;
                }
            }
            temp = TwentyInRegister;
            while ((totalAmount % 20) < totalAmount && temp > 0)
            {
                if (totalAmount - 20 > 0)
                {
                    changeInTwenties++;
                    temp--;
                    remainingAmount = totalAmount - 100;
                    totalAmount = remainingAmount;
                }
            }
            temp = TenInRegister;
            while ((totalAmount % 10) < totalAmount && temp > 0)
            {
                if (totalAmount - 10 > 0)
                {
                    changeInTens++;
                    temp--;
                    remainingAmount = totalAmount - 100;
                    totalAmount = remainingAmount;
                }
            }
            temp = FiveInRegister;
            while ((totalAmount % 5) < totalAmount && temp > 0)
                {
                    if (totalAmount - 5 > 0)
                    {
                        changeInFives++;
                    temp--;
                    remainingAmount = totalAmount - 100;
                        totalAmount = remainingAmount;
                    }
                }
            temp = TwoInRegister;
            while ((totalAmount % 2) < totalAmount && temp > 0)
            {
                if (totalAmount - 2 > 0)
                {
                    changeInTwos++;
                    temp--;
                    remainingAmount = totalAmount - 100;
                    totalAmount = remainingAmount;
                    
                }
            }
            temp = OneInRegister;
            while ((totalAmount % 1) < totalAmount && temp > 0)
            {
                if (totalAmount - 1 > 0)
                {
                    changeInOnes++;
                    temp--;
                    remainingAmount = totalAmount - 100;
                    totalAmount = remainingAmount;
                }
            }
            temp = DollarCoinInRegister;
            while ((totalAmount % 1) < totalAmount && temp > 0)
            {
                if (totalAmount - 1 > 0)
                {
                    changeInDollarCoins++;
                    temp--;
                    remainingAmount = totalAmount - 100;
                    totalAmount = remainingAmount;
                }
            }
            temp = HalfDollarInRegister;
            while ((totalAmount % .50) < totalAmount && temp > 0)
            {
                if (totalAmount - .50 > 0)
                {
                    changeInHalfDollars++;
                    temp--;
                    remainingAmount = totalAmount - 100;
                    totalAmount = remainingAmount;
                }
            }
            temp = QuarterInRegister;
            while ((totalAmount % .25) < totalAmount && temp > 0)
            {
                if (totalAmount - .25 > 0)
                {
                    changeInQuarters++;
                    temp--;
                    remainingAmount = totalAmount - 100;
                    totalAmount = remainingAmount;
                }
            }
            temp = DimeInRegister;
            while ((totalAmount % .10) < totalAmount && temp > 0)
            {
                if (totalAmount - .10 > 0)
                {
                    changeInDimes++;
                    temp--;
                    remainingAmount = totalAmount - 100;
                    totalAmount = remainingAmount;
                }
            }
            temp = NickelInRegister;
            while ((totalAmount % .05) < totalAmount && temp > 0)
            {
                if (totalAmount - .05 > 0)
                {
                    changeInNickels++;
                    temp--;
                    remainingAmount = totalAmount - 100;
                    totalAmount = remainingAmount;
                }
            }
            temp = PennyInRegister;
            while ((totalAmount % .01) < totalAmount && temp > 0)
            {
                if (totalAmount - .01 > 0)
                {
                    changeInPennies++;
                    temp--;
                    remainingAmount = totalAmount - 100;
                    totalAmount = remainingAmount;
                }
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeInHundreds"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeInFifties"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeInTwenties"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeInTens"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeInFives"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeInTwos"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeInOnes"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDollarCoins"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeInHalfDollars"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeInQuarters"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeInDimes"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeInNickels"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeInPennies"));
        }
      
        

    }
}
