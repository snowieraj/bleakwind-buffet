/*Author: Andrew Yi
 *Class: CandlehearthCoffeeEdit.xaml.cs
 *Purpose: Control the buttons of this item
 */
using BleakwindBuffet.Data.Drinks;
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
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for CandlehearthCoffeeEdit.xaml
    /// </summary>
    public partial class CandlehearthCoffeeEdit : UserControl
    {
        //Temp data contsruct
        CandlehearthCoffee itemTemp;
        /// <summary>
        /// Menu contruct
        /// </summary>
        private MenuScreen menuScreen = new MenuScreen();
        /// <summary>
        /// menu constructor
        /// </summary>
        /// <param name="menuItem">Menu item chosen</param>
        public CandlehearthCoffeeEdit(MenuScreen menuItem, CandlehearthCoffee item)
        {
            InitializeComponent();
            menuScreen = menuItem;
            DataContext = item;
            itemTemp = item;
        }
        /// <summary>
        /// Go back button
        /// </summary>
        /// <param name="sender">go back</param>
        /// <param name="e">event</param>
        void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            menuScreen.menuBorder.Child = menuScreen.buttonSelections;
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
                    case "small":
                        itemOne.IsChecked = true;
                        itemTwo.IsChecked = false;
                        itemThree.IsChecked = false;
                        itemSize = Size.Small;
                        break;
                    case "medium":
                        itemOne.IsChecked = false;
                        itemTwo.IsChecked = true;
                        itemThree.IsChecked = false;
                        itemSize = Size.Medium;
                        break;
                    case "large":
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
