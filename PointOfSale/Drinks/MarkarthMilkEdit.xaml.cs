/*Author: Andrew Yi
 *Class: MarkarthMilkEdit.xaml.cs
 *Purpose: Control the buttons of this item
 */
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

namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for MarkarthMilkEdit.xaml
    /// </summary>
    public partial class MarkarthMilkEdit : UserControl
    {
        /// <summary>
        /// Menu reference
        /// </summary>
        private MenuScreen menuScreen = new MenuScreen();
        /// <summary>
        /// Class contruct
        /// </summary>
        /// <param name="menuItem">item chosen</param>
        public MarkarthMilkEdit(MenuScreen menuItem)
        {
            InitializeComponent();
            menuScreen = menuItem;
        }
        /// <summary>
        /// Go back button
        /// </summary>
        /// <param name="sender">click</param>
        /// <param name="e">event</param>
        void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            menuScreen.menuBorder.Child = menuScreen.buttonSelections;
        }
    }
}
