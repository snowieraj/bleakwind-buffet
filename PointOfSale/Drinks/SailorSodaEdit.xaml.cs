/*Author: Andrew Yi
 *Class: AretinoAppleJuiceEdit.xaml.cs
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
    /// Interaction logic for SailorSodaEdit.xaml
    /// </summary>
    public partial class SailorSodaEdit : UserControl
    {
        /// <summary>
        /// Menu ref
        /// </summary>
        private MenuScreen menuScreen = new MenuScreen();
        /// <summary>
        /// Class constuct to get menu chosen
        /// </summary>
        /// <param name="menuItem">Item chosen</param>
        public SailorSodaEdit(MenuScreen menuItem)
        {
            InitializeComponent();
            menuScreen = menuItem;
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

       
    }
}
