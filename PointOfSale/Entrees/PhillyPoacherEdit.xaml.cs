﻿/*Author: Andrew Yi
 *Class: PhillyPoacherEdit.xaml.cs
 *Purpose: Control the buttons of this item
 */
using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for PhillyPoacherEdit.xaml
    /// </summary>
    public partial class PhillyPoacherEdit : UserControl
    {
        //Temp data construct
        PhillyPoacher itemTemp;
        /// <summary>
        /// Menu ref
        /// </summary>
        private MenuScreen menuScreen = new MenuScreen();
        //order ticket
        private Order orderItem;
        //combo item
        private Combination comboItem;
        /// <summary>
        /// Class contruct to get item chosen
        /// </summary>
        /// <param name="menuItem">item chosen</param>
        public PhillyPoacherEdit(MenuScreen menuItem, PhillyPoacher item, Order order, Combination combo)
        {
            InitializeComponent();
            menuScreen = menuItem;
            DataContext = item;
            itemTemp = item;
            orderItem = order;
            comboItem = combo;
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
