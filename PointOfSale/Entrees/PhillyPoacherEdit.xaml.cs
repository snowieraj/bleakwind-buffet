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

        /// <summary>
        /// Class contruct to get item chosen
        /// </summary>
        /// <param name="menuItem">item chosen</param>
        public PhillyPoacherEdit(MenuScreen menuItem, PhillyPoacher item)
        {
            InitializeComponent();
            menuScreen = menuItem;
            DataContext = item;
            itemTemp = item;
        }
        /// <summary>
        /// Go back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            menuScreen.menuBorder.Child = menuScreen.buttonSelections;
        }
    }
}
