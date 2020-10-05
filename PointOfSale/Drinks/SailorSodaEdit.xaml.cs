/*Author: Andrew Yi
 *Class: AretinoAppleJuiceEdit.xaml.cs
 *Purpose: Control the buttons of this item
 */
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
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
    /// Interaction logic for SailorSodaEdit.xaml
    /// </summary>
    public partial class SailorSodaEdit : UserControl

    {
        //Temp data construct
        SailorSoda itemTemp;
        /// <summary>
        /// Menu ref
        /// </summary>
        private MenuScreen menuScreen = new MenuScreen();
        /// <summary>
        /// Class constuct to get menu chosen
        /// </summary>
        /// <param name="menuItem">Item chosen</param>
        public SailorSodaEdit(MenuScreen menuItem, SailorSoda item)
        {
            InitializeComponent();
            menuScreen = menuItem;
            DataContext = item;
            itemTemp = item;
        }
        /// <summary>
        /// Go back to menu screen
        /// </summary>
        /// <param name="sender">click</param>
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

        private void flavorCheckBox(object sender, RoutedEventArgs e)
        {
            SodaFlavor sodaFlavor;
            if (sender is CheckBox check)
            {
                switch (check.Name)
                {
                    case "cherry":
                        itemFive.IsChecked = true;
                        itemSix.IsChecked = false;
                        itemSeven.IsChecked = false;
                        itemEight.IsChecked = false;
                        itemNine.IsChecked = false;
                        itemTen.IsChecked = false;
                        sodaFlavor = SodaFlavor.Cherry;
                        break;
                    case "watermelon":
                        itemFive.IsChecked = false;
                        itemSix.IsChecked = true;
                        itemSeven.IsChecked = false;
                        itemEight.IsChecked = false;
                        itemNine.IsChecked = false;
                        itemTen.IsChecked = false;
                        sodaFlavor = SodaFlavor.Watermelon;
                        break;
                    case "blackberry":
                        itemFive.IsChecked = false;
                        itemSix.IsChecked = false;
                        itemSeven.IsChecked = true;
                        itemEight.IsChecked = false;
                        itemNine.IsChecked = false;
                        itemTen.IsChecked = false;
                        sodaFlavor = SodaFlavor.Blackberry;
                        break;
                    case "grapefruit":
                        itemFive.IsChecked = false;
                        itemSix.IsChecked = false;
                        itemSeven.IsChecked = false;
                        itemEight.IsChecked = true;
                        itemNine.IsChecked = false;
                        itemTen.IsChecked = false;
                        sodaFlavor = SodaFlavor.Grapefruit;
                        break;
                    case "lemon":
                        itemFive.IsChecked = false;
                        itemSix.IsChecked = false;
                        itemSeven.IsChecked = false;
                        itemEight.IsChecked = false;
                        itemNine.IsChecked = true;
                        itemTen.IsChecked = false;
                        sodaFlavor = SodaFlavor.Lemon;
                        break;
                    case "peach":
                        itemFive.IsChecked = false;
                        itemSix.IsChecked = false;
                        itemSeven.IsChecked = false;
                        itemEight.IsChecked = false;
                        itemNine.IsChecked = true;
                        itemTen.IsChecked = false;
                        sodaFlavor = SodaFlavor.Peach;
                        break;
                    default:
                        throw new NotImplementedException();
                }
                itemTemp.Flavor = sodaFlavor;
                DataContext = itemTemp;
            }
        }

    }
}
