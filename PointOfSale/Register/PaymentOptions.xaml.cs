using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data.Menu;
using RoundRegister;
using PointOfSale.Register;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        //private menuscreen switch
        private MenuScreen menuScreen;
        private Order orderItem;
        private OrderTicket orderTicket;

        public PaymentOptions(MenuScreen menu, OrderTicket ticket)
        {
            InitializeComponent();
            menuScreen = menu;
            orderTicket = ticket;
        }

        void CashPayment_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {

                menuScreen.menuBorder.Child = new CashRegister(menuScreen, order, orderTicket);
            }
        }
        void CreditDebitPayment_Click(object sender, RoutedEventArgs e)
        {
            
            if (DataContext is Order order && order != null)
            {
                var reader = CardReader.RunCard(order.Total);
                if(reader == CardTransactionResult.Approved)
                {
                    PrintReceipt();
                    order.Clear();
                    menuScreen.menuBorder.Child = new ButtonSelections(menuScreen);
                    DependencyObject parent = menuScreen;
                    do
                    {
                        parent = LogicalTreeHelper.GetParent(parent);
                    }
                    while (parent != null && !(parent is MainWindow));
                    ((MainWindow)parent).DataContext = new Order();
                    
                }
                else if (reader == CardTransactionResult.Declined)
                {
                    MessageBox.Show("Card Declined");
                }
                else if (reader == CardTransactionResult.InsufficientFunds)
                {
                    MessageBox.Show("Insufficient Funds");
                }
                else if (reader == CardTransactionResult.IncorrectPin)
                {
                    MessageBox.Show("Incorrect Pin");
                }
                else if (reader == CardTransactionResult.ReadError)
                {
                    MessageBox.Show("Read Error");
                }
            }
        }

        void ReturnToMainMenu_Click(object sender, RoutedEventArgs e)
        {
            menuScreen.menuBorder.Child = new ButtonSelections(menuScreen);
        }
        /// <summary>
        /// Print order receipt
        /// </summary>
        void PrintReceipt()
        {
            if (DataContext is Order order)
            {
                List<string> receipt = new List<string>();
                receipt.Add($"Order #{order.Number}");

                foreach (IOrderItem item in order)
                {
                    if (item.ToString() == "BleakwindBuffet.Data.Menu.Combination") receipt.Add("Combo: ");
                    else receipt.Add($"{item.ToString()} :");
                    foreach (string a in item.SpecialInstructions)
                    {
                        receipt.Add(a);
                    }
                    receipt.Add($"Calories: {item.Calories}");
                    receipt.Add("Price: " + (String.Format("{0:0.00}", item.Price)));
                    receipt.Add("\n");
                    
                }
                receipt.Add($"Total Calories: {order.Calories}");
                receipt.Add($"Subtotal: {((String.Format("{0:0.00}", order.Subtotal)))}");
                receipt.Add("Tax: " + ((String.Format("{0:0.00}", order.Tax))));
                receipt.Add("Total: " + ((String.Format("{0:0.00}", order.Total))));

                foreach (string itemorder in receipt)
            {
                RecieptPrinter.PrintLine(itemorder);
            }
            RecieptPrinter.CutTape();
            }
            
        }
    }
}
