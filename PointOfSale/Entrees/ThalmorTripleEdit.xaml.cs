/*Author: Andrew Yi
 *Class: ThalmorTripleEdit.xaml.cs
 *Purpose: Control the buttons of this item
 */using System;
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

namespace PointOfSale.Entrees
{
    /// <summary>
    /// Interaction logic for ThalmorTripleEdit.xaml
    /// </summary>
    public partial class ThalmorTripleEdit : UserControl
    {
        /// <summary>
        /// menu ref
        /// </summary>
        private MenuScreen menuScreen = new MenuScreen();
        /// <summary>
        /// Class contruct get the item chosen
        /// </summary>
        /// <param name="menuItem">iitem chosen</param>
        public ThalmorTripleEdit(MenuScreen menuItem)
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
