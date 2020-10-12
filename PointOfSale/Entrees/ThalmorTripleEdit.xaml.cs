﻿/*Author: Andrew Yi
 *Class: ThalmorTripleEdit.xaml.cs
 *Purpose: Control the buttons of this item
 */using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace PointOfSale.Entrees
{
    /// <summary>
    /// Interaction logic for ThalmorTripleEdit.xaml
    /// </summary>
    public partial class ThalmorTripleEdit : UserControl
    {
        //Temp data construct
        ThalmorTriple itemTemp;
        /// <summary>
        /// menu ref
        /// </summary>
        private MenuScreen menuScreen = new MenuScreen();

        private Order orderItem;
        /// <summary>
        /// Class contruct get the item chosen
        /// </summary>
        /// <param name="menuItem">iitem chosen</param>
        public ThalmorTripleEdit(MenuScreen menuItem, ThalmorTriple item, Order order)
        {
            InitializeComponent();

            menuScreen = menuItem;
            DataContext = item;
            itemTemp = item;
            orderItem = order;
        }
        /// <summary>
        /// Go back button 
        /// </summary>
        /// <param name="sender">Click</param>
        /// <param name="e">event</param>
        void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            menuScreen.menuBorder.Child = new ButtonSelections(menuScreen);

            DataContext = orderItem;
            if (DataContext is Order ordered)
            {
                var itemRemoved = itemTemp;
                ordered.Remove(itemRemoved);
            }

        }
        /// <summary>
        /// Done button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            menuScreen.menuBorder.Child = new ButtonSelections(menuScreen);


        }

    }
}
