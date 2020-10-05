/*Author: Andrew Yi
 *Class: OrderTicket.xaml
 *Purpose: Keep track of what has been ordered
 */

using BleakwindBuffet.Data.Drinks;
using PointOfSale.Drinks;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderTicket.xaml
    /// </summary>
    public partial class OrderTicket : UserControl
    {
        public OrderTicket()
        {
            InitializeComponent();
            Initialtotal();
            
        }

        /// <summary>
        /// Total TextBox
        /// </summary>
        void Initialtotal()
        {
            //total.Text = $"Subtotal: {Subtotal}\nTax: {Tax}\nTotal: {String.Format("{0:00.00}", Subtotal+Tax)}";
            total.Text = "Subtotal: \nTax: \nTotal: ";
            orderNumber.Text = "Order# 100";
            itemsOrdered.Items.Refresh();
        }

       
    }
    
}
