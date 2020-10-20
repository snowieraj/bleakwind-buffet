using BleakwindBuffet.Data.Menu;
using PointOfSale;
using PointOfSale.Register;
using RoundRegister;
using System;
using System.Collections.Generic;
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

namespace PointOfSale.Register
{
    /// <summary>
    /// Interaction logic for CashRegister.xaml
    /// </summary>
    public partial class CashRegister : UserControl
    {
        
        private MenuScreen menuScreen;
        private Order order;
        private OrderTicket ticketItem;

        public CashRegister(MenuScreen menu, Order orderItem, OrderTicket ticket)
        {
            InitializeComponent();
            menuScreen = menu;
            DataContext = orderItem;
            DataContext = new RegisterModelView(orderItem, this);
            order = orderItem;
            ticketItem = ticket;
        }
        /// <summary>
        /// Return the button menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToMenu_Click(object sender, RoutedEventArgs e)
        {
            menuScreen.menuBorder.Child = new ButtonSelections(menuScreen);
        }
        /// <summary>
        /// Finalze sale 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FinalizeSale_Click(object sender, RoutedEventArgs e)
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
            
            MessageBox.Show("Sale Completed");
            
            

        }
        /// <summary>
        /// Print order receipt
        /// </summary>
        void PrintReceipt()
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
