/*Author: Andrew Yi
 *Class: MarkarthMilkEdit.xaml.cs
 *Purpose: Control the buttons of this item
 */
using BleakwindBuffet.Data.Drinks;
using System;
using BleakwindBuffet.Data.Menu;
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
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for MarkarthMilkEdit.xaml
    /// </summary>
    public partial class MarkarthMilkEdit : UserControl
    {
        //Temp data construct
        MarkarthMilk itemTemp;
        /// <summary>
        /// Menu reference
        /// </summary>
        private MenuScreen menuScreen = new MenuScreen();
        //ordered ticket
        private Order orderItem;
        //Combo item
        private Combination comboItem;
        /// <summary>
        /// Class contruct
        /// </summary>
        /// <param name="menuItem">item chosen</param>
        public MarkarthMilkEdit(MenuScreen menuItem, MarkarthMilk item, Order order, Combination combo)
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
        /// <summary>
        /// Check box data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkbox(object sender, RoutedEventArgs e)
        {
            Size itemSize;
            if (sender is CheckBox check)
            {
                switch (check.Name)
                {
                    case "itemOne":
                        itemOne.IsChecked = true;
                        itemTwo.IsChecked = false;
                        itemThree.IsChecked = false;
                        itemSize = Size.Small;
                        break;
                    case "itemTwo":
                        itemOne.IsChecked = false;
                        itemTwo.IsChecked = true;
                        itemThree.IsChecked = false;
                        itemSize = Size.Medium;
                        break;
                    case "itemThree":
                        itemOne.IsChecked = false;
                        itemTwo.IsChecked = false;
                        itemThree.IsChecked = true;
                        itemSize = Size.Large;
                        break;
                    default:
                        throw new NotImplementedException();
                }
                itemTemp.Size = itemSize;
                DataContext = itemTemp;
            }
        }
    }
}
